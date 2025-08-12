import { launch } from "puppeteer"

;(async () => {
  // Launch the browser and open a new blank page, if there is none
  const browser = await launch({
    headless: false
  })
  const page = (await browser.pages()).find(() => true) || (await browser.newPage())

  // Set screen size
  await page.setViewport({
    width: 1920,
    height: 1080,
    deviceScaleFactor: 1,
    isMobile: false,
    hasTouch: false,
    isLandscape: false
  })

  const url = "https://www.wowhead.com/guide/classes/shaman/elemental/bis-gear#trinkets"

  try {
    await page.goto(url)

    try {
      await page.waitForSelector(".tier-list-rows", { timeout: 5000 })
    } catch {
      console.log("No tier list found")
      return
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

    console.log(JSON.stringify(result, null, 2))
  } finally {
    await browser.close()
  }
})()
