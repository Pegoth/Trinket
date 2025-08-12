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

  const url = "https://bloodmallet.com/chart/evoker/devastation/trinkets/castingpatchwerk"

  try {
    await page.goto(url)
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

    console.log(JSON.stringify(result, null, 2))
  } finally {
    await browser.close()
  }
})()
