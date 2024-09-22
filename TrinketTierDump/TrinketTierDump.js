const puppeteer = require('puppeteer');
const fs = require('fs/promises');

(async () => {
    // Launch the browser and open a new blank page
    const browser = await puppeteer.launch({
        headless: 'new'
    });
    const page = await browser.newPage();

    // Set screen size
    await page.setViewport({ width: 1080, height: 1024 });

    // Load the cache
    let specs;
    try {
        specs = JSON.parse(await fs.readFile("specsCache.json"));
        console.log("Loaded specs cache");
    } catch (err) {
        // Get all available guides
        console.log("Loading guide links...");

        // Navigate the page to a URL
        await page.goto('https://www.wowhead.com');

        // Hover class menu
        const menu = await page.waitForSelector(".header-nav-wrapper a[href='/classes']");
        await menu.hover();
        await page.waitForSelector("table.menu-columns:has(a[href^='/guide/classes']) a:not(.menu-item-heading)");

        // Read guide links
        const guides = await page.evaluate(() => $("table.menu-columns:has(a[href^='/guide/classes']) a:not(.menu-item-heading)").map((_, dom) => `https://www.wowhead.com${$(dom).attr("href").replace(/\/[^\/]*?$/, "/bis-gear#trinkets")}`).get());

        // Load the guide and get the trinket tier lists
        let i = 1;
        console.log("Loading guides...");
        specs = {};
        for (const url of guides) {
            console.log(`[${String(i++).padStart(String(guides.length).length, "0")}/${guides.length}]: ${url}`);

            let tryCounter = 0;
            try {
                await page.goto(url);
                await page.waitForSelector(".tier-list-rows");
                const result = await page.evaluate(() => {
                    const data = {
                        key: document.title.replace(/\s*Gear and.*/, ""),
                        value: {}
                    }

                    // Go through each tier
                    $(".tier-list-rows .tier-list-tier").each((_, tierdom) => {
                        const tier = $(tierdom);
                        const tierName = tier.find(".tier-label").text();

                        // Go through each trinket in the tier
                        tier.find(".tier-content a").each((_, linkdom) => {
                            const links = [linkdom.href.replace(/(item=\d+).*/g, "$1")];
                            links.push(links[0].replace("/beta/", "/"));
                            links.push(links[0].replace("www.", ""));
                            links.push(links[0].replace("www.", "").replace("/beta/", "/"));

                            let note = "";
                            for (const link of links) {
                                note = $(`ul>li>div:has(a[href^='${link}']) div:last`).text();
                                if (note != "")
                                    break;
                            }

                            data.value[links[links.length - 1]] = {
                                tier: tierName,
                                note: note
                            };
                        });
                    })

                    return data;
                });

                specs[result.key] = result.value;
            } catch (err) {
                if (++tryCounter > 5)
                    throw err;
                await new Promise(r => setTimeout(r, 5000));
            }

            // Save loaded data to cache
            await fs.writeFile("specsCache.json", JSON.stringify(specs, null, 2));
        }
    }

    // Load the name cache
    let extraDataCache;
    try {
        extraDataCache = JSON.parse(await fs.readFile("extraDataCache.json"));
    } catch (err) {
        extraDataCache = {};
    }

    // Parse the gathered data
    console.log("Parsing data...");
    const trinkets = {};
    for (const [spec, data] of Object.entries(specs)) {
        for (const [link, tierData] of Object.entries(data)) {
            // Read item name
            if (extraDataCache[link] == null) {
                console.log(`Loading ${link}`);
                let tryCounter = 0;
                try {
                    await page.goto(link);
                    await page.waitForSelector("h1.heading-size-1");
                    extraDataCache[link] = await page.evaluate(() => {
                        return {
                            name: $("h1.heading-size-1").text(),
                            icon: $("div>div.iconlarge :first").css("background-image").replace(/.*\"([^\"]+)\".*/g, "$1")
                        }
                    });
                } catch (err) {
                    if (++tryCounter > 5)
                        throw err;
                    await new Promise(r => setTimeout(r, 5000));
                }
                await fs.writeFile("extraDataCache.json", JSON.stringify(extraDataCache, null, 2));
            }

            // Add trinket if needed
            const extraData = extraDataCache[link];
            if (trinkets[extraData.name] == null)
                trinkets[extraData.name] = {};

            // Add data
            trinkets[extraData.name][spec] = {
                tier: tierData.tier,
                icon: extraData.icon,
                link: link,
                note: tierData.note
            };
        }
    }

    console.log("Done");
    await fs.writeFile("../Trinket/wwwroot/trinkets.js", `var trinkets = ${JSON.stringify(trinkets, null, 2)}`);
    await browser.close();
})();