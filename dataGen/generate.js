const puppeteer = require("puppeteer")
const fs = require("fs/promises")

;(async () => {
  // Launch the browser and open a new blank page
  const browser = await puppeteer.launch({
    headless: "new"
  })
  const page = await browser.newPage()

  // Set screen size
  await page.setViewport({ width: 1080, height: 1024 })

  // Items
  let itemNames
  const usedItems = new Set()
  try {
    // No need to invalidate itemNames cache, as it is not time sensitive
    itemNames = JSON.parse(await fs.readFile("caches/itemNames.json"))
  } catch {
    itemNames = {}
  }

  // Load wowhead data
  let wowhead
  try {
    // Get the cache last modified date
    const stats = await fs.stat("caches/wowhead.json")
    if (stats.mtime - new Date() >= 86400000) {
      console.log("Wowhead cache is too old")
      throw new Error()
    }

    wowhead = JSON.parse(await fs.readFile("caches/wowhead.json"))
    Object.values(wowhead)
      .flatMap((specData) => specData.map((tierData) => tierData.item))
      .forEach((itemId) => usedItems.add(itemId))

    console.log("Loaded wowhead cache")
  } catch {
    // Get all available guides
    console.log("Loading wowhead guide links...")

    // Navigate the page to a URL
    await page.goto("https://www.wowhead.com")

    // Hover class menu
    const menu = await page.waitForSelector(".header-nav-wrapper a[href='/classes']")
    await menu.hover()
    await page.waitForSelector("table.menu-columns:has(a[href^='/guide/classes']) a:not(.menu-item-heading)")

    // Read guide links
    const guides = await page.evaluate(() =>
      $("table.menu-columns:has(a[href^='/guide/classes']) a:not(.menu-item-heading)")
        .map(
          (_, dom) =>
            `https://www.wowhead.com${$(dom)
              .attr("href")
              .replace(/\/[^\/]*?$/, "/bis-gear#trinkets")}`
        )
        .get()
    )

    // Load the guide and get the trinket tier lists
    let i = 1
    console.log("Loading wowhead guides...")
    wowhead = {}
    for (const url of guides) {
      console.log(`[${String(i++).padStart(String(guides.length).length, "0")}/${guides.length}]: ${url}`)

      let tryCounter = 0
      try {
        await page.goto(url)
        await page.waitForSelector(".tier-list-rows")
        const result = await page.evaluate(() => {
          const data = {
            key: document.title.replace(/\s*Gear and.*/, ""),
            value: []
          }

          // Go through each tier
          $(".tier-list-rows .tier-list-tier").each((_, tierdom) => {
            const tier = $(tierdom)
            const tierName = tier.find(".tier-label").text()

            // Go through each trinket in the tier
            tier.find(".tier-content a").each((_, linkdom) => {
              const links = [linkdom.href.replace(/(item=\d+).*/g, "$1")]
              links.push(links[0].replace("/beta/", "/"))
              links.push(links[0].replace("www.", ""))
              links.push(links[0].replace("www.", "").replace("/beta/", "/"))

              let note = ""
              for (const link of links) {
                note = $(`ul>li>div:has(a[href^='${link}']) div:last`).text()
                if (note != "") break
              }

              data.value.push({
                item: parseInt(links[links.length - 1].match(/item=(\d+)/)[1]),
                tier: tierName.toUpperCase(),
                note: note
              })
            })
          })

          return data
        })

        // Add used items to the list
        result.value.forEach((tierData) => usedItems.add(tierData.item))

        wowhead[result.key] = result.value
      } catch (err) {
        if (++tryCounter > 5) {
          throw err
        }
        await new Promise((r) => setTimeout(r, 5000))
      }

      // Save loaded data to cache
      await fs.writeFile("caches/wowhead.json", JSON.stringify(wowhead, null, 2))
    }
  }

  // Load bloodmallet data
  let bloodmallet
  try {
    // Get the cache last modified date
    const stats = await fs.stat("caches/bloodmallet.json")
    if (stats.mtime - new Date() >= 86400000) {
      console.log("Bloodmallet cache is too old")
      throw new Error()
    }

    bloodmallet = JSON.parse(await fs.readFile("caches/bloodmallet.json"))
    Object.values(bloodmallet)
      .flatMap(Object.values)
      .flatMap((tierDatas) => tierDatas.map((tierData) => tierData.item))
      .forEach((itemId) => usedItems.add(itemId))

    console.log("Loaded bloodmallet cache")
  } catch {
    // Get all available links
    console.log("Loading bloodmallet class links...")

    // Navigate the page to a URL
    await page.goto("https://bloodmallet.com")

    // Wait for the page to load
    await page.waitForSelector("#spec_table")

    // Read links
    const links = await page.evaluate(() => {
      const data = []
      document.querySelectorAll("#spec_table a.spec-btn:not(.btn-disabled)").forEach((linkdom) => data.push(linkdom.href))
      return data
    })
    const targets = ["", "3", "5"]
    const max = links.length * targets.length

    // Load the guide and get the trinket tier lists
    let i = 1
    console.log("Loading bloodmallet data...")
    bloodmallet = {}
    for (const url of links) {
      // Go through each target amount
      for (const target of targets) {
        console.log(`[${String(i++).padStart(String(max).length, "0")}/${max}]: ${url}${target}`)

        let tryCounter = 0
        try {
          await page.goto(`${url}${target}`)
          await page.waitForSelector("#chart .bm-row .bm-key a")
          await page.waitForSelector("#chart .bm-row .bm-bar .bm-bar-element")
          const result = await page.evaluate(() => {
            const data = {
              key: `${document.getElementById("navbar_wow_spec_selection").text.trim()} ${document.getElementById("navbar_wow_class_selection").text.trim()}`,
              value: []
            }

            // Go through each trinket
            let index = 1
            document.querySelectorAll("#chart .bm-row .bm-key a").forEach((linkdom) => {
              data.value.push({
                item: parseInt(linkdom.href.match(/item=(\d+)/)[1]),
                itemName: linkdom.textContent.trim(),
                tier: index++
              })
            })

            return data
          })

          // Add used items to the list and also update item names
          result.value.forEach((tierData) => {
            usedItems.add(tierData.item)

            // Only update item names if needed and it is not a special item name
            if (
              tierData.itemName != null &&
              tierData.itemName != "" &&
              tierData.itemName.indexOf("[") < 0 &&
              (itemNames[tierData.item] == null || itemNames[tierData.item] == "")
            ) {
              itemNames[tierData.item] = tierData.itemName
            }
          })

          if (bloodmallet[result.key] == null) {
            bloodmallet[result.key] = {}
          }

          bloodmallet[result.key][target == "" ? "1" : target] = result.value.map((tierData) => ({
            item: tierData.item,
            tier: tierData.tier
          }))
        } catch (err) {
          if (++tryCounter > 5) throw err
          await new Promise((r) => setTimeout(r, 5000))
        }
      }

      // Save loaded data to cache
      await fs.writeFile("caches/bloodmallet.json", JSON.stringify(bloodmallet, null, 2))
      await fs.writeFile("caches/itemNames.json", JSON.stringify(itemNames, null, 2))
    }
  }

  // Load spec and class names (from bloodmallet, as it is easier)
  let specs
  try {
    // Get the cache last modified date
    const stats = await fs.stat("caches/specs.json")
    if (stats.mtime - new Date() >= 86400000) {
      console.log("Specs cache is too old")
      throw new Error()
    }

    specs = JSON.parse(await fs.readFile("caches/specs.json"))
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
    await fs.writeFile("caches/specs.json", JSON.stringify(specs, null, 2))
  }

  // Build used item names
  const items = {}
  for (const itemId of usedItems) {
    if (itemNames[itemId] == null || itemNames[itemId] == "") {
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
      await fs.writeFile("caches/itemNames.json", JSON.stringify(itemNames, null, 2))
    }

    // Flip id->name around
    items[itemNames[itemId]] = itemId
  }

  await browser.close()

  // Get cache stats
  const wowheadStats = await fs.stat("caches/wowhead.json")
  const bloodmalletStats = await fs.stat("caches/bloodmallet.json")

  // Cleanup output directory
  try {
    await fs.rm("../trinketData", { recursive: true })
  } catch {}
  await fs.mkdir("../trinketData")

  // Write output
  await fs.writeFile(
    "../trinketData/data.version.json",
    JSON.stringify({
      lastUpdated: (wowheadStats.mtime < bloodmalletStats.mtime ? wowheadStats.mtime : bloodmalletStats.mtime).toISOString()
    })
  )

  await fs.writeFile(
    "../trinketData/data.json",
    JSON.stringify(
      {
        specs: specs,
        items: items,
        wowhead: wowhead,
        bloodmallet: bloodmallet
      },
      (key, value) => (key == "item" ? itemNames[value] : value)
    )
  )

  console.log("Done")
})()
