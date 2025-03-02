import { launch } from "puppeteer"
import { readFile, stat, writeFile, rm, mkdir } from "fs/promises"
import getWowhead from "./wowhead"
import getBloodmallet from "./bloodmallet"
;(async () => {
  // Launch the browser and open a new blank page
  const browser = await launch({
    headless: false
  })
  const page = await browser.newPage()

  // Set screen size
  await page.setViewport({ width: 1080, height: 1024 })

  try {
    await mkdir("caches")
  } catch {}

  // Items
  let itemNames
  const usedItems = new Set()
  try {
    // No need to invalidate itemNames cache, as it is not time-sensitive
    itemNames = JSON.parse(await readFile("caches/itemNames.json", { encoding: "utf8" }))
  } catch {
    itemNames = {}
  }

  const wowhead = await getWowhead(page, usedItems)
  const bloodmallet = await getBloodmallet(page, usedItems, itemNames)

  // Load spec and class names (from bloodmallet, as it is easier)
  let specs
  try {
    // Get the cache last modified date
    const stats = await stat("caches/specs.json")
    if (new Date() - stats.mtime >= 86400000) {
      console.log("Specs cache is too old")
      throw new Error()
    }

    specs = JSON.parse(await readFile("caches/specs.json", { encoding: "utf8" }))
    console.log("Loaded specs cache")
  } catch {
    // Get all available links
    console.log("Loading specs link...")

    // Navigate the page to a URL
    await page.goto("https://bloodmallet.com")

    // Wait for the page to load
    await page.waitForSelector("#spec_table")

    // Read links
    specs = await page.evaluate(() => {
      const data = {}
      document.querySelectorAll("#spec_table .spec-cell").forEach((classdom) => {
        const specList = []
        classdom.querySelectorAll(".spec-btn").forEach((specdom) => specList.push(specdom.text))
        data[classdom.querySelector(".wow-class-header-content").textContent] = specList
      })
      return data
    })

    // Save loaded data to cache
    await writeFile("caches/specs.json", JSON.stringify(specs, null, 2))
  }

  // Build used item names
  const items = {}
  for (const itemId of usedItems) {
    if (itemNames[itemId] == null || itemNames[itemId] === "") {
      console.log("Loading item name for id", itemId)
      let tryCounter = 0
      try {
        // Navigate the page to a URL
        await page.goto(`https://wowhead.com/item=${itemId}`)
        await page.waitForSelector("h1")
        itemNames[itemId] = await page.evaluate(() => document.querySelector("h1").textContent.trim())
      } catch (err) {
        if (++tryCounter > 5) throw err
        await new Promise((r) => setTimeout(r, 5000))
      }

      // Save loaded data to cache
      await writeFile("caches/itemNames.json", JSON.stringify(itemNames, null, 2))
    }

    // Flip id->name around
    items[itemNames[itemId]] = itemId
  }

  await browser.close()

  // Get cache stats
  const wowheadStats = await stat("caches/wowhead.json")
  const bloodmalletStats = await stat("caches/bloodmallet.json")

  // Cleanup output directory
  try {
    await rm("../trinketData", { recursive: true })
  } catch {}
  await mkdir("../trinketData")

  // Write output
  await writeFile(
    "../src/assets/data.json",
    JSON.stringify(
      {
        lastUpdated: (wowheadStats.mtime < bloodmalletStats.mtime ? wowheadStats.mtime : bloodmalletStats.mtime).toISOString(),
        specs: specs,
        items: items,
        wowhead: Object.values(wowhead).reduce((acc, { name, items }) => {
          acc[name] = items
          return acc
        }, {}),
        bloodmallet: Object.values(bloodmallet).reduce((acc, { name, ...rest }) => {
          acc[name] = rest
          return acc
        }, {})
      },
      (key, value) => (key === "item" ? itemNames[value] : value)
    )
  )

  console.log("Done")
})()
