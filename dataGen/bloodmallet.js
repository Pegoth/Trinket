import { readFile, stat, writeFile } from "fs/promises"

export default async function (page, usedItems, itemNames) {
  // Load bloodmallet data
  let bloodmallet = {}
  try {
    // Get the cache last modified date
    const stats = await stat("caches/bloodmallet.json")
    if (new Date() - stats.mtime >= 86400000) {
      console.log("Bloodmallet cache is too old")
    } else {
      bloodmallet = JSON.parse(await readFile("caches/bloodmallet.json", { encoding: "utf8" }))
      Object.values(bloodmallet).forEach((value) => {
        if (Array.isArray(value)) value.flatMap((tierDatas) => tierDatas.forEach((tierData) => usedItems.add(tierData.item)))
      })
      console.log("Loaded bloodmallet cache")
    }
  } catch (err) {
    console.log("Failed to load bloodmallet cache", err)
  }

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
  for (const url of links) {
    // Go through each target amount
    for (const target of targets) {
      console.log(`[${String(i++).padStart(String(max).length, "0")}/${max}]: ${url}${target}`)
      if (bloodmallet[url] != null && bloodmallet[url][target === "" ? "1" : target] != null) continue

      let tryCounter = 0
      while (true) {
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
              tierData.itemName !== "" &&
              tierData.itemName.indexOf("[") < 0 &&
              (itemNames[tierData.item] == null || itemNames[tierData.item] === "")
            ) {
              itemNames[tierData.item] = tierData.itemName
            }
          })

          if (bloodmallet[url] == null) {
            bloodmallet[url] = {
              name: result.key
            }
          }

          bloodmallet[url][target === "" ? "1" : target] = result.value.map((tierData) => ({
            item: tierData.item,
            tier: tierData.tier
          }))

          // Save loaded data to cache
          await writeFile("caches/bloodmallet.json", JSON.stringify(bloodmallet, null, 2))
          await writeFile("caches/itemNames.json", JSON.stringify(itemNames, null, 2))

          break
        } catch (err) {
          if (++tryCounter > 5) throw err
          console.log(`Error (${tryCounter}):`, err)
          await new Promise((r) => setTimeout(r, 5000))
        }
      }
    }
  }

  return bloodmallet
}
