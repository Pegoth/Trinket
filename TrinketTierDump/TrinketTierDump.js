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
    const classes = {};
    let i = 1;
    console.log("Loading guides...");
    for (const url of guides) {
        console.log(`[${String(i++).padStart("0", String(guides.length).length)}/${guides.length}]: ${url}`);

        const tryCounter = 0;
        try {
            await page.goto(url);
            const result = await page.evaluate(() => {
                const data = {
                    key: document.title.replace(/\s*Gear and.*/, ""),
                    value: {}
                }

                $("table.grid:has(tr td:contains('Grade'))").each((_, griddom) => {
                    $(griddom).find("tr").each((_, rowdom) => {
                        const cols = $(rowdom).find("td").get();
                        if (cols[0].textContent != "Grade") {
                            const key = cols[1].textContent.replace(/^\s*/, "");

                            if (data.value[key] == null)
                                data.value[key] = {
                                    tier: cols[0].textContent,
                                    //source: cols[2].textContent,
                                    note: cols[cols.length - 1].textContent
                                };
                            else
                                console.log("Duplicate trinket:", key);
                        }
                    })
                })

                return data;
            });

            classes[result.key] = result.value;
        } catch (err) {
            if (++tryCounter > 5)
                throw err;
            await new Promise(r => setTimeout(r, 5000));
        }
    }

    await browser.close();

    // Parse the gathered data
    const trinkets = {}
    for (const [c, t] of Object.entries(classes)) {
        for (const [n, d] of Object.entries(t)) {
            if (trinkets[n] == null)
                trinkets[n] = {};

            trinkets[n][c] = d;
        }
    }

    await fs.writeFile("../Trinket/wwwroot/trinkets.js", `var trinkets = ${JSON.stringify(trinkets, null, 2)}`);
})();