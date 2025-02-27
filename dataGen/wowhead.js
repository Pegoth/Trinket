import { readFile, stat, writeFile } from "fs/promises"

export default async function (page, usedItems) {
  // Load wowhead data
  let wowhead = {}
  try {
    // Get the cache last modified date
    const stats = await stat("caches/wowhead.json")
    if (new Date() - stats.mtime >= 86400000) {
      console.log("Wowhead cache is too old")
    } else {
      wowhead = JSON.parse(await readFile("caches/wowhead.json", { encoding: "utf8" }))
      Object.values(wowhead)
        .flatMap((specData) => specData.items.map((tierData) => tierData.item))
        .forEach((itemId) => usedItems.add(itemId))
      console.log("Loaded wowhead cache")
    }
  } catch {
    console.log("Failed to load wowhead cache")
  }

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
  for (const url of guides) {
    console.log(`[${String(i++).padStart(String(guides.length).length, "0")}/${guides.length}]: ${url}`)
    if (wowhead[url] != null) continue

    let tryCounter = 0
    while (true) {
      try {
        await page.goto(url)

        try {
          await page.waitForSelector(".tier-list-rows", { timeout: 5000 })
        } catch {
          console.log("No tier list found")
          break
        }

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
            tier.find(".tier-content>a").each((_, linkdom) => {
              const links = [linkdom.href.replace(/(item=\d+).*/g, "$1")]
              links.push(links[0].replace("/beta/", "/"))
              links.push(links[0].replace("www.", ""))
              links.push(links[0].replace("www.", "").replace("/beta/", "/"))

              let note = ""
              for (const link of links) {
                note = $(`ul > li > div:has(a[href^='${link}']) div:last`).text()
                if (note !== "") break
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

        wowhead[url] = {
          name: result.key,
          items: result.value
        }

        // Save loaded data to cache
        await writeFile("caches/wowhead.json", JSON.stringify(wowhead, null, 2), { encoding: "utf8" })

        break
      } catch (err) {
        if (++tryCounter > 5) throw err
        console.log(`Error (${tryCounter}):`, err)
        await new Promise((r) => setTimeout(r, 5000))
      }
    }
  }

  return wowhead
}
