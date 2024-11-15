namespace Trinket.Data;

public static class TrinketData
{
    public static DateTime LastUpdated { get; } = DateTime.Parse("2024-11-15T13:35:43.346Z");

    public static Dictionary<string, Dictionary<string, TierModel>> Trinkets { get; } = new()
    {
        {
            "Aberrant Spellforge", new Dictionary<string, TierModel>
            {
                {
                    "Devastation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_aberrantspellforge_pink.jpg", "https://wowhead.com/item=212451", "Strong passive damage proc trinket with a lackluster on-use effect. Be careful using this if you plan to use another trinket before the 20 second trinket cooldown finishes. Moves to B tier in AOE.")
                },
                {
                    "Elemental Shaman",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_aberrantspellforge_pink.jpg", "https://wowhead.com/item=212451", "")
                },
                {
                    "Arcane Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_aberrantspellforge_pink.jpg", "https://wowhead.com/item=212451", "A boring proc trinket in disguise - make sure you don't use it if you're going to use another trinket within 20s for your cooldowns.")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_aberrantspellforge_pink.jpg", "https://wowhead.com/item=212451", "Essentially an Intellect stat stick that becomes more powerful over the course of an encounter. This trinket is quite decent when allowed to ramp up, notably in progression raid encounters, but is significantly less effective in dungeon content like Mythic+ or Delves.")
                },
                {
                    "Demonology Warlock",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_aberrantspellforge_pink.jpg", "https://wowhead.com/item=212451", "While empowering your  Courtyard Scene is decently strong on its own, once you are able to properly sync the on use with our cooldown cycle it gains some additional value from free Haste and even more damage amplification for  Courtyard Scene.")
                },
                {
                    "Destruction Warlock",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_aberrantspellforge_pink.jpg", "https://wowhead.com/item=212451", "A different type of on-use trinket that doesn't share cooldown with other on-use trinkets. Essentially works as a very small 1-minute power boost, and a passive haste buff.")
                },
                {
                    "Affliction Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_aberrantspellforge_pink.jpg", "https://wowhead.com/item=212451", "")
                },
                {
                    "Balance Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_aberrantspellforge_pink.jpg", "https://wowhead.com/item=212451", "")
                },
                {
                    "Fire Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_aberrantspellforge_pink.jpg", "https://wowhead.com/item=212451", "Passive damage proc trinket with a lackluster on-use effect. Be careful using this if you plan to use another trinket before the 20 second trinket cooldown finishes.")
                },
                {
                    "Frost Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_aberrantspellforge_pink.jpg", "https://wowhead.com/item=212451", "")
                },
                {
                    "Shadow Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_aberrantspellforge_pink.jpg", "https://wowhead.com/item=212451", "")
                }
            }
        },
        {
            "Abyssal Trap", new Dictionary<string, TierModel>
            {
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C+", "https://wow.zamimg.com/images/wow/icons/large/ability_shawaterelemental_split.jpg", "https://wowhead.com/item=215170", "Grants static Agility and an on-use effect with 1 minute cooldown that deals uncapped AoE damage. It's pretty solid, but has a maximum item level of 626.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/ability_shawaterelemental_split.jpg", "https://wowhead.com/item=215170", "")
                },
                {
                    "Frost Death Knight",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/ability_shawaterelemental_split.jpg", "https://wowhead.com/item=215170", "")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/ability_shawaterelemental_split.jpg", "https://wowhead.com/item=215170", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/ability_shawaterelemental_split.jpg", "https://wowhead.com/item=215170", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/ability_shawaterelemental_split.jpg", "https://wowhead.com/item=215170", "")
                },
                {
                    "Feral Druid",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/ability_shawaterelemental_split.jpg", "https://wowhead.com/item=215170", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/ability_shawaterelemental_split.jpg", "https://wowhead.com/item=215170", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/ability_shawaterelemental_split.jpg", "https://wowhead.com/item=215170", "")
                }
            }
        },
        {
            "Algari Alchemist Stone", new Dictionary<string, TierModel>
            {
                {
                    "Protection Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "This is an easy to get trinket that you can look into if you have some bad luck with dungeon or raid drops.")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C+", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "Grants static Versatility and a 1 RPPM proc of a large Agility buff, as well as boosting the effect of healing potions. Not great, but a decent crafted option if you have spare sparks and no good trinkets. It has a maximum item level of 636.")
                },
                {
                    "Affliction Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Destruction Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Holy Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Protection Warrior",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "Easy access trinket, however would not recommend committing a spark to it as there are several good and easy-to-farm trinkets from Mythic+!")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Frost Mage",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Retribution Paladin",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "Passive Strength proc. No special usage required.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Feral Druid",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=210816", "")
                }
            }
        },
        {
            "Ara-Kara Sacbrood", new Dictionary<string, TierModel>
            {
                {
                    "Affliction Warlock",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Unique trinket that grants Intellect once eggs are spawned. When they hatch, damage is also dealt. The hatching of eggs takes a bit of time however to occur.")
                },
                {
                    "Assassination Rogue",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "A fan favorite and strong passive proc from Bfa makes a return. It's still great and should be sought out if you don't get your hands on  Ara-Kara Sacbrood first")
                },
                {
                    "Demonology Warlock",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "A very strong passive trinket and part of our full BIS setup. The passive Haste is fine and the proc effect can line up very nicely with  Summon Demonic Tyrant cycles, giving us additional Intellect.")
                },
                {
                    "Elemental Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Provides passive Haste which at the start of the expansion we're absolutely desperate for and a very generous uptime rolling Agility proc, alongside a tiny amount of additional damage. Excellent all around for all situations, and very simple.")
                },
                {
                    "Frost Death Knight",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Frost's strongest passive stat trinket this season, with a flavorful damage proc on top. Expect to generally have a few stacks going at a time.")
                },
                {
                    "Guardian Druid",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "A nice passive trinket that grants our Primary stat and deals some minor damage.")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Half of the value of the trinket is due to helping us reach the Haste breakpoints required. A great option in general but depending on your Haste levels might be slightly worse than the other options.")
                },
                {
                    "Protection Paladin",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "This is the best trinket available right now. It has passive haste and a solid proc rate of constant passive damage and strength. You'll have ~1-3 stacks of the strength buff at any given time.")
                },
                {
                    "Protection Warrior",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "A very potent trinket just like  Ara-Kara Sacbrood but instead comes with a fairly strong on-use which gets increased by 20% per stack consumed. However, it doesn't stack as quickly as  Ara-Kara Sacbrood.")
                },
                {
                    "Retribution Paladin",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Passive stat trinket with a small DoT component. No special usage required.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("S-", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Havoc's strongest passive trinket, with a powerful rolling Agility buff that can stack. All around great, but not BiS in single-target.")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("A+", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("A+", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "This trinket provides static Haste and a 2.5 RPPM effect that grants an Agility buff for an entire minute before hatching, dealing a Nature DoT to an enemy. Each egg proc generates a separate buff, so once it's running, it grants 2.5x as much Agility, on average, as stated on the tooltip.")
                },
                {
                    "Arcane Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Our strongest passive trinket from a dungeon, it sounds interesting but its the definition of a trinket you don't think about.")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Passive Haste and an effect that provides essentially passive Intellect as well as direct damage. This trinket specifically deals Nature damage, which can be noteworthy for certain item interactions.")
                },
                {
                    "Balance Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "A unique trinket that grants Intellect once eggs are spawned. They deal damage once they hatch, though note that the actual hatching process takes some time to occur. This trinket's stat budge is very high for both AoE and single-target.")
                },
                {
                    "Blood Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Gives you a decent amount of primary stat on a proc. The static budget on it is not great but the trinket's effect makes up for it. It is the best of a bad bunch, and completely passive.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Despite having static Haste, the 2.5ppm effect of this trinket grants its Agility buff for an entire minute before the egg hatches and applies its Nature DoT to an enemy. This all comes together for a surprisingly effective trinket.")
                },
                {
                    "Destruction Warlock",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Essentially functions as a passive main stat bonus, with an additional damage function once the eggs time out. Over-all, a very nice trinket for a lot of people.")
                },
                {
                    "Devastation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Very strong passive trinket. Chance to proc damage and return intellect.")
                },
                {
                    "Discipline Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Haste with passive intellect")
                },
                {
                    "Feral Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "The best passive stat trinket for AoE, where other options fall behind. While you'll still want a primary on-use trinket, a secondary trinket that provides a stat boost rather than direct damage becomes a lot more attractive, and it helps that this is also very competitive on single-target. This is also best option for a second trinket on Mythic+.")
                },
                {
                    "Fire Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Very strong passive trinket. Chance to proc damage and return intellect.")
                },
                {
                    "Frost Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "This is the best passive stat trinket for Frost Mages in The War Within Season 1.")
                },
                {
                    "Holy Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "")
                },
                {
                    "Holy Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Haste with passive intellect")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "With a baseline amount of Haste (do you see the pattern starting to form?), the passive effect provides a surprisingly good amount of Intellect, making it just a hair stronger than [item=178708 bonus=[=gv-sl-dun:6917] and its effect. The damage that it does is just a nice extra perk this trinket brings, but it isn't the reason it ranks as high as it does.")
                },
                {
                    "Preservation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "This is a full budget stat stick with a small DPS bonus attached. Sadly it's also a haste trinket so it's just decent for us.")
                },
                {
                    "Restoration Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "This is a weird DPS trinket that actually ends up being a full budget stat stick with a small DPS bonus. You don't need to play around it though casting an occasional DPS spell will be of increased value.")
                },
                {
                    "Restoration Shaman",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "This is another solid stat-stick where multiple stacks \"overlap\". This seems especially nice in a Mythic+ setting, as the damage procs also add in a small amount of damage.")
                },
                {
                    "Shadow Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Unique trinket that grants intellect once eggs are spawned, when they hatch, damage is also dealt. This trinket is finnicky to use and requires a long time to get full value, but can be interesting in some situations.")
                },
                {
                    "Survival Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "Performs very well for both ST and AoE alike, making it an incredibly versatile trinket! it does not currently compare that well against some of the pre-season offerings, but those are unavailable at higher itemlevels once season 1 begins.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "A passive trinket that can be quite strong if obtained at high item levels through the Great Vault. Generally worse than  Ara-Kara Sacbrood.")
                },
                {
                    "Windwalker Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "The slight nerf it recieved moves it down to A from S, but it is still the 2nd best trinket with an \"Equip\" effect.")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_red.jpg", "https://wowhead.com/item=219314", "")
                }
            }
        },
        {
            "Bottled Flayedwing Toxin", new Dictionary<string, TierModel>
            {
                {
                    "Vengeance Demon Hunter",
                    new TierModel("A+", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "This has static Agility, and it deals more damage than any other trinket available aside from  Void Reaper's Contract. When you use it, it grants an hour-long buff that allows your attacks to proc a Nature DoT  Flayedwing Toxin with 4+Haste RPPM.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "Due to being penalized on tank specializations for being a dps trinket, this item is only a decent choice rather than one of the absolute best. Remember to re-apply its effect when the buff expires or you have died!")
                },
                {
                    "Guardian Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "Provides a chunk of our Primary stat with a small on-use damage effect, making this one of the better DPS trinkets from Mythic+.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "")
                },
                {
                    "Feral Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "A passive trinket that requires you to apply it once every hour, similar to  Instant Poison. This resets on death so don't forget!!")
                },
                {
                    "Survival Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "Deals very sustained single target damage, competing even with some of the S-tier options. However, it struggles to deal AoE damage effectively, dropping its overall rating down a lot.")
                },
                {
                    "Windwalker Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_alchemy_70_potion2.jpg", "https://wowhead.com/item=178742", "")
                }
            }
        },
        {
            "Candle Confidant", new Dictionary<string, TierModel>
            {
                {
                    "Arcane Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_candlepet.jpg", "https://wowhead.com/item=225648", "The ally is really cute.")
                },
                {
                    "Devastation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_candlepet.jpg", "https://wowhead.com/item=225648", "This trinket summons candle pets that attack your target. It does a surprising amount of damage.")
                },
                {
                    "Fire Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_candlepet.jpg", "https://wowhead.com/item=225648", "This trinket summons candle pets that attack your target. It does a surprising amount of damage.  The AI on the minions it spawns is kind of bad so it likely will underperform in AoE. Only really recommended for Single Target.")
                },
                {
                    "Frost Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_candlepet.jpg", "https://wowhead.com/item=225648", "A very strong trinket that drops in delves. Because the summoned pet can be a melee attacker, this trinket is better if you stay close to your target.")
                },
                {
                    "Destruction Warlock",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_candlepet.jpg", "https://wowhead.com/item=225648", "Summons a little guy that actually does quite decent damage. But this trinket can be hard to obtain at a decent ilevel, making it the top of B tier.")
                },
                {
                    "Demonology Warlock",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_candlepet.jpg", "https://wowhead.com/item=225648", "")
                }
            }
        },
        {
            "Carved Blazikon Wax", new Dictionary<string, TierModel>
            {
                {
                    "Holy Priest",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_candlekobold_color1.jpg", "https://wowhead.com/item=219305", "Solid stat stick.")
                }
            }
        },
        {
            "Ceaseless Swarmgland", new Dictionary<string, TierModel>
            {
                {
                    "Protection Warrior",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_organmass_color2.jpg", "https://wowhead.com/item=219316", "Does a moderate amount of damage accompanied by a strong flat damage reduction which is very powerful as a Protection Warrior!")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C+", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_organmass_color2.jpg", "https://wowhead.com/item=219316", "This trinket has static Agility and a 6+Haste RPPM proc which occurs on damage taken, putting a 6 second DoT on enemies that also reduces their damage dealt to you by a flat amount for 6 seconds. It's not bad overall, but not great.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_organmass_color2.jpg", "https://wowhead.com/item=219316", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_organmass_color2.jpg", "https://wowhead.com/item=219316", "")
                }
            }
        },
        {
            "Cirral Concoctory", new Dictionary<string, TierModel>
            {
                {
                    "Elemental Shaman",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Preservation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "Gives various buffs to your allies including an int proc, secondary procs, tertiary procs and more. It's too inconsistent to be great.")
                },
                {
                    "Restoration Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "A bizarre proc trinket that will give various buffs to your allies including an int proc, secondary procs, tertiary procs and more. The primary stat buff is actually very strong but you'll get it too inconsistently.")
                },
                {
                    "Holy Paladin",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Affliction Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "Passive Intellect and an effect that seems at first glance to be an interesting support effect for Augmentation Evoker. In practice the average result is rather lackluster, making the support aspect of this trinket fairly weak.")
                },
                {
                    "Balance Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Discipline Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Holy Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Arcane Mage",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Devastation Evoker",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Fire Mage",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Shadow Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_tentaclevial_red.jpg", "https://wowhead.com/item=219321", "")
                }
            }
        },
        {
            "Concoction: Kiss of Death", new Dictionary<string, TierModel>
            {
                {
                    "Arcane Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "The limited ilvl here does not matter, this trinket is very strong on its own despite the ilevel restriction on delve loot.")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Feral Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "A strong trinket but one that is limited in item level to Heroic levels only. At comparable item levels, its one of the best secondary trinket options available.")
                },
                {
                    "Protection Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Discipline Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Holy Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Protection Warrior",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                },
                {
                    "Survival Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_engineersgrease_color1.jpg", "https://wowhead.com/item=215174", "")
                }
            }
        },
        {
            "Corrupted Egg Shell", new Dictionary<string, TierModel>
            {
                {
                    "Discipline Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_cat_trinket09.jpg", "https://wowhead.com/item=133305", "")
                },
                {
                    "Holy Paladin",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_cat_trinket09.jpg", "https://wowhead.com/item=133305", "")
                },
                {
                    "Holy Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_cat_trinket09.jpg", "https://wowhead.com/item=133305", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_cat_trinket09.jpg", "https://wowhead.com/item=133305", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_cat_trinket09.jpg", "https://wowhead.com/item=133305", "")
                },
                {
                    "Preservation Evoker",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_cat_trinket09.jpg", "https://wowhead.com/item=133305", "Does not have intellect on it.")
                },
                {
                    "Restoration Druid",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_cat_trinket09.jpg", "https://wowhead.com/item=133305", "")
                }
            }
        },
        {
            "Creeping Coagulum", new Dictionary<string, TierModel>
            {
                {
                    "Holy Priest",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_creepingcoagulum_purple.jpg", "https://wowhead.com/item=219917", "On-use that redirects part of your healing to feed the coagulum. When it is fully fed it detonates for a burst of healing.")
                },
                {
                    "Discipline Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_creepingcoagulum_purple.jpg", "https://wowhead.com/item=219917", "On-use that redirects part of your healing to feed the coagulum. When it is fully fed it detonates for a burst of healing.")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_creepingcoagulum_purple.jpg", "https://wowhead.com/item=219917", "When you use this trinket, it reduces your healing by 20% until you meet its cap, which happens quickly, and then it turns that amplifies that stored healing to heal several allies. Thankfully, there's an additional effect if it overheals its targets, allowing them to deal some extra damage to their target. This trinket is definitely one that you need to time its use very well with upcoming mechanics, but at least there's still some value if you get the timing a little off, or it decides to heal someone who doesn't need the healing. Because you can guarantee the five allies it'll healin Mythic+, this is defintiely something worth keeping if you haven't had much luck getting better trinkets.")
                },
                {
                    "Preservation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_creepingcoagulum_purple.jpg", "https://wowhead.com/item=219917", "It's very easy to contribute enough healing to proc the burst here quickly so you'll use this during any dangerous damage.")
                },
                {
                    "Restoration Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_creepingcoagulum_purple.jpg", "https://wowhead.com/item=219917", "This is a slightly awkward on-use healing trinket which is likely to be fairly good in lower tier content and worse by the time you get to Mythic. It also gives you a little free damage via the allies you heal.")
                },
                {
                    "Restoration Shaman",
                    new TierModel("B+", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_creepingcoagulum_purple.jpg", "https://wowhead.com/item=219917", "While you do \"lose\" healing to charge up this trinket, the healing it does is decent and it also does an okay amount of damage for the group. This might be a nice trinket for Mythic+ especially.")
                },
                {
                    "Holy Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_creepingcoagulum_purple.jpg", "https://wowhead.com/item=219917", "A simple on use trinket that heals 5 players after a while of you \"filling it up\", which you do by simply continuing to heal normally.")
                }
            }
        },
        {
            "Darkmoon Deck: Ascension", new Dictionary<string, TierModel>
            {
                {
                    "Frost Mage",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckevolution_0.jpg", "https://wowhead.com/item=222680", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckevolution_0.jpg", "https://wowhead.com/item=222680", "")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckevolution_0.jpg", "https://wowhead.com/item=222680", "Ascension is a relatively powerful trinket for its item level. While it does not hold up once you get to normal raid or higher item level trinkets, it is a good trinket to have access to early on.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckevolution_0.jpg", "https://wowhead.com/item=222680", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckevolution_0.jpg", "https://wowhead.com/item=222680", "")
                }
            }
        },
        {
            "Darkmoon Deck: Radiance", new Dictionary<string, TierModel>
            {
                {
                    "Frost Mage",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckshine_0.jpg", "https://wowhead.com/item=219672", "")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckshine_0.jpg", "https://wowhead.com/item=219672", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckshine_0.jpg", "https://wowhead.com/item=219672", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckshine_0.jpg", "https://wowhead.com/item=219672", "")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckshine_0.jpg", "https://wowhead.com/item=219672", "")
                }
            }
        },
        {
            "Darkmoon Deck: Symbiosis", new Dictionary<string, TierModel>
            {
                {
                    "Frost Mage",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription_darkmooncards_spore_blank.jpg", "https://wowhead.com/item=222653", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription_darkmooncards_spore_blank.jpg", "https://wowhead.com/item=222653", "")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription_darkmooncards_spore_blank.jpg", "https://wowhead.com/item=222653", "")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription_darkmooncards_spore_blank.jpg", "https://wowhead.com/item=222653", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription_darkmooncards_spore_blank.jpg", "https://wowhead.com/item=222653", "")
                }
            }
        },
        {
            "Darkmoon Deck: Vivacity", new Dictionary<string, TierModel>
            {
                {
                    "Frost Mage",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckvivacity_0.jpg", "https://wowhead.com/item=222671", "")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckvivacity_0.jpg", "https://wowhead.com/item=222671", "An interesting trinket based on stacking different spell schools to maximize its effects. Cannot be crafted above item level 577, and is overtaken by the  Darkmoon Sigil: Vivacity  embellishment instead.")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckvivacity_0.jpg", "https://wowhead.com/item=222671", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckvivacity_0.jpg", "https://wowhead.com/item=222671", "")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckvivacity_0.jpg", "https://wowhead.com/item=222671", "")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_inscriptions_darkmoondeckvivacity_0.jpg", "https://wowhead.com/item=222671", "")
                }
            }
        },
        {
            "Dead-Eye Spyglass", new Dictionary<string, TierModel>
            {
                {
                    "Assassination Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "A fan favorite and strong passive proc from Bfa makes a return. It's still great and should be sought out if you don't get your hands on  Ara-Kara Sacbrood first")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "")
                },
                {
                    "Feral Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "Similar to Sacbrood, this is one of the best Secondary stat trinkets available.")
                },
                {
                    "Guardian Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "Can grant impressive amounts of Critical Strike.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "Powerful passive trinket. Note, however, that it drops in value if you need to swap targets frequently, which  Burning Wound can cause in Mythic+ scenarios.")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "Useful for sustained fights, but not great for stop-start situations like Mythic+, since the Trinket stacks a debuff on the target that obviously gets reset if that target dies.")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "This trinket is generally weaker on single target than the other options, but the added cleave damage could be important for dungeons depending on your comp.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "The marks are target-bound. When using this trinket in Mythic+, make sure to keep attacking the same target if possible when using this option.")
                },
                {
                    "Survival Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "Very similar to  Empowering Crystal of Anub'ikkaj, but has a downside attached to where in order to stack up the crit buff you need to be attacking the target it procced from. This can somewhat lower its expected stat returns in an environment where it can proc on a very fast dying mob you didn't neccesarily want it to proc onto. With that said, it still provides a great amount of critical strike.")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "This trinket grants static Agility and a massive amount of Critical Strike with 1 RPPM for 10 seconds, with roughly 16.7% uptime.")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("B+", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "A solid Crit stat stick that's generally quite strong if you can maintain it. Unfortunately, in AoE this has a habit of proccing on things that are about to die, which massively reduces its value in Mythic+ situations. Still, good for raids and scenarios when you can maximize procs.")
                },
                {
                    "Windwalker Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_spyglass_02.jpg", "https://wowhead.com/item=159623", "")
                }
            }
        },
        {
            "Detachable Fang", new Dictionary<string, TierModel>
            {
                {
                    "Subtlety Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_redsaberonfang.jpg", "https://wowhead.com/item=225657", "")
                },
                {
                    "Feral Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_redsaberonfang.jpg", "https://wowhead.com/item=225657", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_redsaberonfang.jpg", "https://wowhead.com/item=225657", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_redsaberonfang.jpg", "https://wowhead.com/item=225657", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_redsaberonfang.jpg", "https://wowhead.com/item=225657", "")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_redsaberonfang.jpg", "https://wowhead.com/item=225657", "")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_redsaberonfang.jpg", "https://wowhead.com/item=225657", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_redsaberonfang.jpg", "https://wowhead.com/item=225657", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C-", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_redsaberonfang.jpg", "https://wowhead.com/item=225657", "")
                },
                {
                    "Frost Death Knight",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_redsaberonfang.jpg", "https://wowhead.com/item=225657", "")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_redsaberonfang.jpg", "https://wowhead.com/item=225657", "")
                }
            }
        },
        {
            "Empowering Crystal of Anub'ikkaj", new Dictionary<string, TierModel>
            {
                {
                    "Enhancement Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Passive Agility along with a 1.55 RPPM frequency secondary boost that, while random, is still extremely valuable this early in the expansion when we're desperate for any stat. Simple and effective in all situations.")
                },
                {
                    "Holy Priest",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Excellent stat stick, even with a random stat buff")
                },
                {
                    "Affliction Warlock",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Quite powerful baseline Intellect with a secondary proc effect trinket. Can also be farmed outside raid (The Dawnbreaker).")
                },
                {
                    "Arcane Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Boring passive, but potent!")
                },
                {
                    "Assassination Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "This trinket is a nice passive proc trinket, but it is fairly RNG. The good news is that all secondary stats are good for Assassination, so there's no proc that \"feels bad\" in that regard")
                },
                {
                    "Balance Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "This trinket has a powerful amount of baseline Intellect with a random Secondary stat proc effect. Can also be farmed outside of raid, as it comes from The Dawnbreaker dungeon.")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "For a strong proc trinket, this is one of our better options. We are not too bothered by the random stats you can gain and it can be farmed outside of the raid, giving us good opportunity to have a strong trinket prior to raiding.")
                },
                {
                    "Destruction Warlock",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Passive main stat and a random secondary passive stat proc is very strong for us. We scale well off of pretty much every seconday.")
                },
                {
                    "Devastation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Passive secondary stat increase to a random stat.")
                },
                {
                    "Discipline Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Excellent stat stick, even with a random stat buff")
                },
                {
                    "Elemental Shaman",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "")
                },
                {
                    "Feral Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "While not quite as competitive as the Spyglass or Ara-Kara Sacbrood, this is another fine alternative.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Great passive stat trinket, powerful in all content but not absolute best in slot.")
                },
                {
                    "Holy Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "This is just a nice stat stick! While it can give us Haste, Critical Strike, or Versatility, it's lowered a few positions because of the possibility of it giving us Mastery. In Mythic+ however, its ranking is much more impressive because of this! Not much else to say about it though, the base amount of Intellect is great, and the secondary stat buff lasts long enough to make great use of it.")
                },
                {
                    "Preservation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "A fairly generic high uptime stat stick that rotates through random secondaries.")
                },
                {
                    "Restoration Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Another high uptime stat stick. It's a bit worse than the S tier trinkets but it's still very usable.")
                },
                {
                    "Restoration Shaman",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "This is your stereotypical stat-stick. Unfortunately this gives you a random secondary stat, so you can have streaks of \"bad\" secondary stat procs. Not terrible, not great.")
                },
                {
                    "Shadow Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Quite powerful baseline intellect with a secondary proc effect trinket. Can also be farmed outside raid (The Dawnbreaker).")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "")
                },
                {
                    "Survival Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Very similar to  Empowering Crystal of Anub'ikkaj, but has a downside attached to where in order to stack up the crit buff you need to be attacking the target it procced from. This can somewhat lower its expected stat returns in an environment where it can proc on a very fast dying mob you didn't neccesarily want it to proc onto. With that said, it still provides a great amount of critical strike.")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "While not particularly powerful at first glance, this is one of the strongest Secondary stat trinkets available, and Vengeance benefits quite a lot from stats. It has static Agility and has 1.55 RPPM on a 20 second buff, so on average it should have ~51.7% uptime.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "This trinket represents the definition of \"average\", offering a 20 second buff to a random secondary stat roughly 1.55 times per minute. It exists in the background and does nothing special, but is at least reliably doing something.")
                },
                {
                    "Fire Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "Passive secondary stat increase to a random stat.")
                },
                {
                    "Frost Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "This is a passable passive stat trinket.")
                },
                {
                    "Windwalker Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "A typical Intellect stat stick with a random secondary stat proc. On average this trinket produces decent results, but has inherent variability in that it can hit less desirable secondary stats.")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color5.jpg", "https://wowhead.com/item=219312", "")
                }
            }
        },
        {
            "Entropic Skardyn Core", new Dictionary<string, TierModel>
            {
                {
                    "Discipline Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_nullstone_void.jpg", "https://wowhead.com/item=219296", "Mythic0 trinket. Solid option but likely to get replaced later.")
                },
                {
                    "Holy Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_nullstone_void.jpg", "https://wowhead.com/item=219296", "Mythic0 trinket. Solid option but likely to get replaced later.")
                }
            }
        },
        {
            "Everburning Lantern", new Dictionary<string, TierModel>
            {
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C+", "https://wow.zamimg.com/images/wow/icons/large/inv_offhand_1h_draenorcrafted_d_01_c_alliance.jpg", "https://wowhead.com/item=215169", "")
                },
                {
                    "Arcane Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_offhand_1h_draenorcrafted_d_01_c_alliance.jpg", "https://wowhead.com/item=215169", "A stronger passive trinket from delves, it just does some damage, nothing crazy.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_offhand_1h_draenorcrafted_d_01_c_alliance.jpg", "https://wowhead.com/item=215169", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_offhand_1h_draenorcrafted_d_01_c_alliance.jpg", "https://wowhead.com/item=215169", "")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_offhand_1h_draenorcrafted_d_01_c_alliance.jpg", "https://wowhead.com/item=215169", "")
                },
                {
                    "Survival Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_offhand_1h_draenorcrafted_d_01_c_alliance.jpg", "https://wowhead.com/item=215169", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_offhand_1h_draenorcrafted_d_01_c_alliance.jpg", "https://wowhead.com/item=215169", "")
                },
                {
                    "Feral Druid",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_offhand_1h_draenorcrafted_d_01_c_alliance.jpg", "https://wowhead.com/item=215169", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_offhand_1h_draenorcrafted_d_01_c_alliance.jpg", "https://wowhead.com/item=215169", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_offhand_1h_draenorcrafted_d_01_c_alliance.jpg", "https://wowhead.com/item=215169", "")
                }
            }
        },
        {
            "Forged Gladiator's Badge of Ferocity", new Dictionary<string, TierModel>
            {
                {
                    "Feral Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/spell_holy_championsbond.jpg", "https://wowhead.com/item=218713", "This trinket is available from PvP and is a very competitive alternative to other on-use trinkets if they haven't dropped yet.")
                }
            }
        },
        {
            "Foul Behemoth's Chelicera", new Dictionary<string, TierModel>
            {
                {
                    "Guardian Druid",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_foulbehemothschelicera_red.jpg", "https://wowhead.com/item=219915", "Deals decent damage and provides a stacking health effect across the entire fight. This is great on long fights and/or progression.")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("A+", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_foulbehemothschelicera_red.jpg", "https://wowhead.com/item=219915", "This is classed as a Tank trinket, so it doesn't have the damage penalty of DPS trinkets. Because of this, it does damage that is nearly on par with full DPS trinkets, while also having defensive benefits! This is exceptionally good in Mythic+ because it has a short 90 second cooldown, while granting a maximum health buff that's great for bosses, while also generating a shield in between pulls that helps buffer us during our weakest point - on pull, before our defensives get rolling. On top of the buff that can stack up to 20 times, this trinket also grants static Agility.")
                },
                {
                    "Blood Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_foulbehemothschelicera_red.jpg", "https://wowhead.com/item=219915", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_foulbehemothschelicera_red.jpg", "https://wowhead.com/item=219915", "Despite being a tank trinket, the damage output from this item is exceptionally competitive with the strongest options, and that's before considering that it also has additional defensive benefits! Plus, the additional maximum health from overhealing with this trinket ( Nerubian Fortitude) acts as a small buff to your  Touch of Death damage!Seek this out as a potent on-use choice with some hybrid bonuses that likely isn't being claimed by a dps player.")
                },
                {
                    "Protection Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_foulbehemothschelicera_red.jpg", "https://wowhead.com/item=219915", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_foulbehemothschelicera_red.jpg", "https://wowhead.com/item=219915", "Is technically not a DPS trinket option but seems to do decent damage with added benefits from the increased maximum health/shield.")
                },
                {
                    "Protection Warrior",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_foulbehemothschelicera_red.jpg", "https://wowhead.com/item=219915", "")
                }
            }
        },
        {
            "Fungal Friend Flute", new Dictionary<string, TierModel>
            {
                {
                    "Discipline Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/8xp_vulperaflute.jpg", "https://wowhead.com/item=215171", "")
                },
                {
                    "Holy Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/8xp_vulperaflute.jpg", "https://wowhead.com/item=215171", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/8xp_vulperaflute.jpg", "https://wowhead.com/item=215171", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/8xp_vulperaflute.jpg", "https://wowhead.com/item=215171", "")
                }
            }
        },
        {
            "Gale of Shadows", new Dictionary<string, TierModel>
            {
                {
                    "Holy Paladin",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=133304", "This trinket procs from HoTs or DoTs only. As such it is great for Herald. For Lightsmith it only procs of  Consecration so you will need to keep it down, which isn't a problem in Dungeons but might be a little annoying in Raid.")
                },
                {
                    "Holy Priest",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=56462", "Very strong intellect gain, currently very highly tuned.")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=133304", "With this trinket set to Haste, it's one of the best options we could hope for in raids. Similar to  Gale of Shadows, this is just a great passive trinket that increases our Intellect and Haste.")
                },
                {
                    "Preservation Evoker",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=133304", "Haste is not our preferred secondary but Gale of Shadows is still a very good trinket since you will maintain 100% uptime and it's slightly overbudget.")
                },
                {
                    "Restoration Druid",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=133304", "You'll get 100% uptime on Gale of Shadows so this is a fantastic, overbudget stat stick. Very strong in all content types.")
                },
                {
                    "Restoration Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=56462", "A strong passive trinket that gives a lot of mainstat. Again, keeping  Flame Shock while healing will regularly proc this trinket.")
                },
                {
                    "Balance Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=133304", "Good trinket that grants a sizable amount of Intellect via its proc. Pretty solid for both AOE and single-target. Can be farmed from the Grim Batol dungeon.")
                },
                {
                    "Devastation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=56462", "Decent passive stat increase. Procs from damage-over-time effects.")
                },
                {
                    "Discipline Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=56462", "Very strong intellect gain, currently very highly tuned.")
                },
                {
                    "Fire Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=56462", "Decent passive stat increase. Procs from damage-over-time effects.")
                },
                {
                    "Frost Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=56462", "This is another good passive stat trinket option. Spellslinger can proc this with  Embedded Frost Splinter while Frostfire can proc this with the damage over time effect applied by  Frostfire Bolt.")
                },
                {
                    "Shadow Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=133304", "")
                },
                {
                    "Affliction Warlock",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=133304", "Gale brings a baseline amount of Haste with a stacking Intellect effect, which is of relatively decent power level.")
                },
                {
                    "Destruction Warlock",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=133304", "We can pretty much always keep this at a decent amount of stacks, making this trinket a very viable option.")
                },
                {
                    "Elemental Shaman",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=133304", "")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=133304", "Once this trinket's stacks are online it is quite effective, but the ramp time does make the effect somewhat less valuable on pull and in dungeon settings like Mythic+ and Delves. Augmentation also generally takes a bit longer than other specs to cast its first periodic effect, which further delays the value gained.")
                },
                {
                    "Arcane Mage",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=56462", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_gathershadows.jpg", "https://wowhead.com/item=133304", "")
                }
            }
        },
        {
            "Goldenglow Censer", new Dictionary<string, TierModel>
            {
                {
                    "Preservation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_incenseholder_color4.jpg", "https://wowhead.com/item=225656", "The shield isn't very big and this isn't available at max level so you'll only use it if you desperately need an on-use shield trinket in Mythic+.")
                },
                {
                    "Restoration Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_incenseholder_color4.jpg", "https://wowhead.com/item=225656", "This isn't a top tier raid trinket but a short cooldown shield can be fairly useful in Mythic+ - even if this one is quite a bit smaller than some we've seen in the past.")
                },
                {
                    "Holy Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_incenseholder_color4.jpg", "https://wowhead.com/item=225656", "This trinket can be used to shield 1 player. Trinkets like this are historically pretty bad for raiding, but are useful in high Mythic+ where they can help provide an extra external.")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_incenseholder_color4.jpg", "https://wowhead.com/item=225656", "")
                },
                {
                    "Discipline Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_incenseholder_color4.jpg", "https://wowhead.com/item=225656", "")
                },
                {
                    "Holy Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_incenseholder_color4.jpg", "https://wowhead.com/item=225656", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_incenseholder_color4.jpg", "https://wowhead.com/item=225656", "")
                }
            }
        },
        {
            "Golem Gearbox", new Dictionary<string, TierModel>
            {
                {
                    "Unholy Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_eng_gizmo3.jpg", "https://wowhead.com/ptr-2/item=231471", "")
                }
            }
        },
        {
            "Gruesome Syringe", new Dictionary<string, TierModel>
            {
                {
                    "Discipline Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_gruesomesyringe_red.jpg", "https://wowhead.com/item=212452", "Mid  passive trinket, providing healing and stats.")
                },
                {
                    "Holy Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_gruesomesyringe_red.jpg", "https://wowhead.com/item=212452", "This trinket is a little strange. You would always prefer to have the intellect, but when you need it the most it will consume the stacks to shoot out a low heal and reduce the intellect it gives which makes this trinket not super good.")
                },
                {
                    "Holy Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_gruesomesyringe_red.jpg", "https://wowhead.com/item=212452", "Mid passive trinket, providing healing and stats.")
                },
                {
                    "Preservation Evoker",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_gruesomesyringe_red.jpg", "https://wowhead.com/item=212452", "Gruesome Syringe is an awkward design because the int proc is more powerful but you'll only get it when nobody is injured.")
                },
                {
                    "Restoration Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_gruesomesyringe_red.jpg", "https://wowhead.com/item=212452", "Gruesome Syringe will mostly play as a flat healing trinket, because you're likely to get the intellect buff when you need it the least (nobody injured). As a result it's poor.")
                },
                {
                    "Restoration Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_gruesomesyringe_red.jpg", "https://wowhead.com/item=212452", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_gruesomesyringe_red.jpg", "https://wowhead.com/item=212452", "")
                }
            }
        },
        {
            "Hadal's Nautilus", new Dictionary<string, TierModel>
            {
                {
                    "Elemental Shaman",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_shell_04.jpg", "https://wowhead.com/item=159622", "")
                },
                {
                    "Affliction Warlock",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_shell_04.jpg", "https://wowhead.com/item=159622", "This is an interesting passive trinket which will spawn waterspouts randomly, increased in damage by the number of targets hit.")
                },
                {
                    "Arcane Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_shell_04.jpg", "https://wowhead.com/item=159622", "A bit better in AOE than in single target, but kind of obnoxious when mobs are moving and it procs.")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_shell_04.jpg", "https://wowhead.com/item=159622", "Passive Intellect coupled with a direct damage proc. This is a simple and effective Augmentation trinket, and the slight damage scaling with targets helps its value in AoE.")
                },
                {
                    "Demonology Warlock",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_shell_04.jpg", "https://wowhead.com/item=159622", "An AoE based damage effect that increases its damage per targets hit on a short internal cooldown. This trinket will be mostly usable in Mythic+, however if the tank moves mobs erratically out of the effect, it loses value quickly.")
                },
                {
                    "Devastation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_shell_04.jpg", "https://wowhead.com/item=159622", "Chance to cause a waterspout that is split between targets, but increases in damage in AOE. This trinket can miss if targets are moving.")
                },
                {
                    "Frost Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_shell_04.jpg", "https://wowhead.com/item=159622", "This is a decent passive trinket that does some extra damage in AoE, but it is problematic against moving targets because it can miss.")
                },
                {
                    "Shadow Priest",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_shell_04.jpg", "https://wowhead.com/item=159622", "This is an interesting passive trinket which will spawn waterspouts randomly, increased in damage by the number of targets hit.")
                },
                {
                    "Balance Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_shell_04.jpg", "https://wowhead.com/item=159622", "")
                },
                {
                    "Destruction Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_shell_04.jpg", "https://wowhead.com/item=159622", "")
                },
                {
                    "Fire Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_shell_04.jpg", "https://wowhead.com/item=159622", "Chance to cause a waterspout that is split between targets, but increases in damage in AOE. This trinket can miss if targets are moving.")
                }
            }
        },
        {
            "Hand of Justice", new Dictionary<string, TierModel>
            {
                {
                    "Enhancement Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_jewelry_talisman_01.jpg", "https://wowhead.com/item=231417", "While this has a staggering 15 (+Haste) RPPM, the actual damage the proc deals isn't that special. The big value comes from the fact that for some inexplicable reason it procs Maelstrom Weapon, making it a heavy hitter for  Stormbringer builds in single target.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_jewelry_talisman_01.jpg", "https://wowhead.com/ptr-2/item=231417", "")
                }
            }
        },
        {
            "Harvester's Edict", new Dictionary<string, TierModel>
            {
                {
                    "Affliction Warlock",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "Trinket provides baseline Intellect and a damage proc. Orbs can also be soaked to increase your Mastery, but requires movement.")
                },
                {
                    "Devastation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "Damage proc that sends out an orb that deals damage. Catching this orb gives you Mastery instead. Better in AoE, but still outclassed by other trinkets.")
                },
                {
                    "Elemental Shaman",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Guardian Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "Decent passive trinket with a Mastery proc.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Survival Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "Incredibly awkard, but very powerful in theory. A lot of the value here comes from the ability to intercept the orb. If you struggle with this the true value is likely closer to C tier.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Holy Paladin",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("C+", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Arcane Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "Kind of a neat trinket idea but not super great in execution.")
                },
                {
                    "Assassination Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "Passive Intellect and an effect that provides either direct damage or Mastery checks all the boxes for Augmentation. The orb effect spawns behind you and quickly moves towards the enemy in such a way that can be difficult to anticipate, especially in combat.")
                },
                {
                    "Balance Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Destruction Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Discipline Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Feral Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Fire Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "Damage proc that sends out an orb that deals damage. Catching this orb gives you Mastery instead. Better in AoE, but still outclassed by other trinkets.")
                },
                {
                    "Frost Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Holy Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Shadow Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C-", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "This trinket has static Agility and a 1.66 RPPM proc on dealing damage, which spawns an orb flying to your current target, dealing split AoE damage. Intercepting the orb grants Mastery for 15 seconds instead. Due to the 33% non-DPS spec penalty, we always want to grab the orb, but it's not great for damage due to being Mastery.")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_oldgodstatuepiece_purple.jpg", "https://wowhead.com/item=219317", "")
                }
            }
        },
        {
            "Heart of Roccor", new Dictionary<string, TierModel>
            {
                {
                    "Unholy Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_ore_blackrock_ore.jpg", "https://wowhead.com/ptr-2/item=231456", "")
                }
            }
        },
        {
            "High Speaker's Accretion", new Dictionary<string, TierModel>
            {
                {
                    "Mistweaver Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "")
                },
                {
                    "Affliction Warlock",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "This trinket simply provides limited upside numerically compared with other available alternatives.")
                },
                {
                    "Balance Druid",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "")
                },
                {
                    "Elemental Shaman",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "")
                },
                {
                    "Shadow Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "")
                },
                {
                    "Arcane Mage",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "")
                },
                {
                    "Devastation Evoker",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "")
                },
                {
                    "Fire Mage",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_magic_swirl_color3.jpg", "https://wowhead.com/item=219303", "")
                }
            }
        },
        {
            "Horn of Declaration", new Dictionary<string, TierModel>
            {
                {
                    "Subtlety Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_horn_03.jpg", "https://wowhead.com/item=217041", "")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_horn_03.jpg", "https://wowhead.com/item=217041", "")
                }
            }
        },
        {
            "Imperfect Ascendancy Serum", new Dictionary<string, TierModel>
            {
                {
                    "Augmentation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "A strong 2 min cooldown stat amplification trinket which aligns well with the  Breath of Eons burst window, and is available immediately at the start of the fight. As a Delve trinket, it cannot be obtained at Myth track item level.")
                },
                {
                    "Protection Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Survival Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Arcane Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "A very strong trinket pound for pound, but being available at a limited ilvl holds it back a ton, the cast time is also a double edged sword, it sucks to use in combat but can also be used before combat so your mileage might vary quite a bit with this trinket.")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Devastation Evoker",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "Cool on-use trinket that changes your model and gives you a strong buff. This trinket requires casting. This trinket is held back by its lower itemlevel.")
                },
                {
                    "Discipline Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Feral Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Fire Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "Cool on-use trinket that changes your model and gives you a strong buff. This trinket requires casting. This trinket is held back by its lower itemlevel.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Holy Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C-", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Frost Death Knight",
                    new TierModel("D+", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "Unfortunately, the Delve trinkets will fall by the wayside because of their item level disadvantage compared to Mythic+ and Raid trinkets. However, this trinket gets an honorable mention as one to look out for if you play  Breath of Sindragosa. Using it puts you into a cocoon for a couple of seconds; then, you pop out with all stats buffed and a new model. Veterans of the spec may be reminded of a certain trinket from The Eternal Palace...")
                },
                {
                    "Affliction Warlock",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "")
                },
                {
                    "Protection Warrior",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "2-minute cooldown trinket which grants a huge burst of stats for 20 seconds. However doesn't line up with any of our cooldowns and the passive stats on the trinket are reduced by large amounts. Bad.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_dpotion_a25.jpg", "https://wowhead.com/item=225654", "Was initially one of the strongest options but got heavily nerfed, is not recommended to be used.")
                }
            }
        },
        {
            "Kaheti Shadeweaver's Emblem", new Dictionary<string, TierModel>
            {
                {
                    "Arcane Mage",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_mawraid_04_purple.jpg", "https://wowhead.com/item=225651", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_mawraid_04_purple.jpg", "https://wowhead.com/item=225651", "")
                }
            }
        },
        {
            "Mad Queen's Mandate", new Dictionary<string, TierModel>
            {
                {
                    "Affliction Warlock",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "Mad Queen's Mandate is essentially our \"Best\" raw single target damage option, but has very little AOE value.")
                },
                {
                    "Assassination Rogue",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "Strong on-use damage. If you can time it for the cooldown reset it's even better, but it's hard to play around and not necessary")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "Critical Strike is an excellent secondary stat for Augmentation Evoker, and the direct damage dealt by this trinket is quite substantial, particularly for an Augmentation Evoker with limited single target burst potential. Additionally, this trinket also becomes more effective against enemies on lower health.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "While it does not feature Agility, Critical Strike is the best secondary you could hope for as a Brewmaster on a trinket like this. Although its damage is noteworthy enough to be your best choice for lower target counts, your success with this trinket will be additionally determined by whether or not you can take advantage of its bonus effects of extra damage on lower-health targets and cooldown reduction for defeating an enemy with it.Beyond that, its heal effect is insignificant, and it should also be noted that you cannot dodge attacks while channeling its 1-second cast time (though you can move during it).")
                },
                {
                    "Demonology Warlock",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "Similar to an item used a lot in Dragonflight,  Iridal, the Earth's Master, this trinket can be used more often if you time the on use with executing a mob. The passive Critical Strike it provides is fine, but Intellect passives will always be better.")
                },
                {
                    "Destruction Warlock",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "Offers a good on-use damage effect, which also works very well in settings where you can benefit from the cooldown reduction function.")
                },
                {
                    "Guardian Druid",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "Can be very powerful if you manage to kill targets with it, which will reduce the on-use cooldown.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "An exceptionally powerful on-use cast, with high variability on a single massive hit that relies on landing a critical strike. Very good, but the RNG of critical strikes can be unappealing. BiS for single-target as a double on-use, usually cast after Skardyn's Grace.")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "Our outright BiS for all things single-target, for any Hero Talent.")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "A powerful on use trinket that can be especially powerful in Mythic plus where you can abuse the resets.")
                },
                {
                    "Protection Warrior",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "This is the single best offensive option trinket obtainable. With a small heal")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("A+", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Blood Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Devastation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "Damage trinket that hits harder in execute. Cooldown halved if target is killed. Moves to B tier in AOE, unless you can consistently get resets on the kill effect.")
                },
                {
                    "Feral Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "The best second trinket option of raids. It's an on-use, but since it deals damage there's no harm in desyncing it from your cooldowns. Does massive damage on use, and since many other specs aren't quite as happy with this trinket as Feral is, it should be fairly easy to obtain due to a lack of competition.")
                },
                {
                    "Retribution Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "On use damage. Use on cooldown unless you won't get another cast during the encounter; in that case you should delay as its damage is increased against lower health targets.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "The best trinket for your 2nd trinket slot but a very contested trinket option.If you get this trinket, use it during  Symbols of Death as TricksterUse it during  Lingering Darkness when playing DeathstalkerIf combined with other on use trinkets like  Treacherous Transmitter, use  Mad Queen's Mandate second.")
                },
                {
                    "Survival Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "This trinket does a HUGE amount of damage with the on-use ability. If you can somehow get it to kill the targets and use it 2x as often, its an easy S-tier trinket.")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Frost Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "It is a good Critical Strike stick with an interesting damage on-use effect. After a brief channel, it deals a huge chunk of damage to your target in an attempt to execute it. This trinket may be fun to play with in Mythic+, where you'll have many opportunities to execute targets for more casts. Use this before or after  Pillar of Frost, or you'll lose a GCD.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "On-use damage trinket that does decent damage, all things considered, but doesn't provide the stats that Unholy would prefer.")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "This trinket grants static Critical Strike and an on-use effect with a 2 minute cooldown. It has a 1 second cast time, during which you are unable to dodge or parry, but deals a massive amount of damage over 2 sec to a priority target, and it deals scaling increased damage to enemies with missing health. In addition, if the enemy dies during the debuff, the cooldown is cut in half to 1 minute, making it a fantastic option in multi-target fights. However, by default it's not as strong as other trinkets that aren't reliant on the cooldown reduction.")
                },
                {
                    "Discipline Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Holy Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Arcane Mage",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Balance Druid",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Elemental Shaman",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Frost Mage",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Shadow Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                },
                {
                    "Fire Mage",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_abyssaleffigy_purple.jpg", "https://wowhead.com/item=212454", "")
                }
            }
        },
        {
            "Mark of Khardros", new Dictionary<string, TierModel>
            {
                {
                    "Frost Death Knight",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_hammer_04.jpg", "https://wowhead.com/item=133300", "Both on-use secondary stat trinkets available for Frost this season are nearly identical.  Skarmorak Shard grants small Mastery buffs when you defeat enemies, making this a bit more attractive than  Mark of Khardros in Mythic+. The 90-second cooldown makes this trinket worthwhile for any build. It will line up with your cooldowns whether you play Deathbringer or Rider of the Apocalypse,  Breath of Sindragosa or  Obliteration.")
                },
                {
                    "Retribution Paladin",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_hammer_04.jpg", "https://wowhead.com/item=133300", "On use Mastery trinket. Use after  Execution Sentence before  Wake of Ashes.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_hammer_04.jpg", "https://wowhead.com/item=133300", "Another great on-use trinket with a 90-second cooldown. Very similar to  Mark of Khardros, but gives slightly less Mastery on use. As compensation, it also grants you a little Mastery when walking near an enemy's corpse. This secondary effect makes this trinket great for Mythic+ and Delves.")
                },
                {
                    "Protection Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_hammer_04.jpg", "https://wowhead.com/item=133300", "Another on-use Mastery option that is better for single-target situations.")
                },
                {
                    "Protection Warrior",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_hammer_04.jpg", "https://wowhead.com/item=56458", "A 1.5-minute cooldown mastery buff will line up with every  Ravager and  Champion's Spear. It's a great offensive option for single-target and AoE alike!")
                },
                {
                    "Blood Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_hammer_04.jpg", "https://wowhead.com/item=133300", "")
                }
            }
        },
        {
            "Mereldar's Toll", new Dictionary<string, TierModel>
            {
                {
                    "Arcane Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_bell_color1.jpg", "https://wowhead.com/item=219313", "A great secondary option to Spymasters, the cooldown of this trinket is what makes it decent, you can get 2/3 of your bursts windows by staggering its usage or just using it off cooldown, either works!.")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_bell_color1.jpg", "https://wowhead.com/item=219313", "This trinket's on-use effect deals direct damage and also provides 5 allies with Versatility. While these sorts of support effects are not always great, this trinket's total output is actually quite good, and is worth considering on Augmentation even though you will be using this as a two-minute trinket combined with your  Breath of Eons as usual. Do note that the Versatility provided to allies will not appear as part of your damage contribution in logs or meters, as you might expect.")
                },
                {
                    "Elemental Shaman",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_bell_color1.jpg", "https://wowhead.com/item=219313", "")
                },
                {
                    "Devastation Evoker",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_bell_color1.jpg", "https://wowhead.com/item=219313", "On use trinket that deals damage and provides secondary stats to you and your allies.")
                },
                {
                    "Discipline Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_bell_color1.jpg", "https://wowhead.com/item=219313", "")
                },
                {
                    "Fire Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_bell_color1.jpg", "https://wowhead.com/item=219313", "On use trinket that deals damage and provides secondary stats to you and your allies.")
                },
                {
                    "Holy Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_bell_color1.jpg", "https://wowhead.com/item=219313", "When used, deals damage to your target and causes the 5 next people to attack that target to be healed and gain a small amount of Vers.")
                },
                {
                    "Holy Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_bell_color1.jpg", "https://wowhead.com/item=219313", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_bell_color1.jpg", "https://wowhead.com/item=219313", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_bell_color1.jpg", "https://wowhead.com/item=219313", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_bell_color1.jpg", "https://wowhead.com/item=219313", "")
                }
            }
        },
        {
            "Mistcaller Ocarina", new Dictionary<string, TierModel>
            {
                {
                    "Beast Mastery Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "Ocarina is a relatively weak trinket on its value to you as the user. However, with the buff applied to all 5 players, it is relatively okay as an option.")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "A cute stat stick trinket that provides an extremely small buff to your party.")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "")
                },
                {
                    "Survival Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "Another delve trinket, aiming more at potentionally buffing allies. However, unlike  Mistcaller Ocarina it appears to split the buff with your ally rather than getting the full effect. This means you might not want to share the buff at all if you happen to have your cooldowns active! As with all Delve trinkets, the maximum itemlevel is limited at 626.")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "")
                },
                {
                    "Feral Druid",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "This trinket grants static Agility and when used, grants a 15 minute buff on you that has a 1 RPPM proc to grant allies a selected Secondary stat for 15 seconds. It's pretty bad, despite being a group support item.")
                },
                {
                    "Windwalker Monk",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_primitive_toy03.jpg", "https://wowhead.com/item=178715", "")
                }
            }
        },
        {
            "Nizrek's Holographic Manipulator", new Dictionary<string, TierModel>
            {
                {
                    "Unholy Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_offhand_1h_nerubianraid_d_01.jpg", "https://wowhead.com/item=225970", "")
                }
            }
        },
        {
            "Oppressive Orator's Larynx", new Dictionary<string, TierModel>
            {
                {
                    "Blood Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_shadowmend.jpg", "https://wowhead.com/item=219318", "")
                },
                {
                    "Protection Warrior",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_shadowmend.jpg", "https://wowhead.com/item=219318", "A very potent trinket just like  Ara-Kara Sacbrood but instead comes with a fairly strong on-use which gets increased by 20% per stack consumed. However, it doesn't stack as quickly as  Ara-Kara Sacbrood.")
                },
                {
                    "Frost Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_shadowmend.jpg", "https://wowhead.com/item=219318", "A better-than-average trinket for Mythic+. Nice passive Strength, and the on-use effect gives us some upfront burst going into a pack.")
                },
                {
                    "Protection Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_shadowmend.jpg", "https://wowhead.com/item=219318", "This gives stacking strength just for attack. You can have ~1-5 stacks of bonus strength and it has an on-use of moderate shadow damage.")
                },
                {
                    "Retribution Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_shadowmend.jpg", "https://wowhead.com/item=219318", "On use damage. Use near the end of combat or against add spawns; keep the Strength stacks otherwise.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_shadowmend.jpg", "https://wowhead.com/item=219318", "Another just-okay trinket that gives a little Strength and does some decent AoE damage. However, as usual, Unholy prefers pure stat trinkets.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/spell_shadow_shadowmend.jpg", "https://wowhead.com/item=219318", "")
                }
            }
        },
        {
            "Overclocked Gear-a-Rang Launcher", new Dictionary<string, TierModel>
            {
                {
                    "Outlaw Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "It is just a damage on-use trinket. There's nothing special about it really.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "")
                },
                {
                    "Feral Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "")
                },
                {
                    "Protection Warrior",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C-", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "This trinket has no stats, but instead has an on-use effect with a 2 minute cooldown that deals damage to enemies in an arc. This damage is reduced for each enemy hit. In addition, it adds a small passive proc on auto-attacks which can reduce the on-use cooldown by 5 seconds and adds a small amount of Fire damage to your next melee. It's not great.")
                },
                {
                    "Frost Death Knight",
                    new TierModel("D+", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "")
                },
                {
                    "Retribution Paladin",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "")
                },
                {
                    "Survival Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_firearm_2h_engineering_c_01_blue.jpg", "https://wowhead.com/item=219301", "The lack of any primary or secondary stat hurts this trinket in particular. The random procced damage it deals is nowhere near worth enough to give up the raw stats.")
                }
            }
        },
        {
            "Ovi'nax's Mercurial Egg", new Dictionary<string, TierModel>
            {
                {
                    "Frost Death Knight",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "It isn't easy to gauge this trinket through sims because it revolves around movement. However, it has excellent potential. Our highest secondary stat will be Critical Strike, and we want it almost as much as we want Strength. It will not be a significant penalty if we move a lot and swap the Strength stacks for Critical Strike stacks. Suspending the Strength buff right before using  Breath of Sindragosa will be ideal. However, there may not be time for the buff to reallocate fully if you move a lot. We want to maintain 10-20 stacks of each buff, taking care not to go to 30 in either direction, as stacks above 20 yield fewer stats.")
                },
                {
                    "Restoration Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "This is a unique take on a passive stat-stick trinket. Standing still will build up stacks of  Deliberate Incubation which increases your mainstat over time, and moving will remove stacks of  Deliberate Incubation and instead grant stacks of  Reckless Incubation. This means you will never get zero value from this trinket, but it does award standing still as mainstat is generally better. Using the trinket will \"suspend\" the procs you have for a period of time, making it quite versatile.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Another passive trinket, but with a quirk. This trinket performs best when you can stand still for extended periods, but getting some extra Haste when you move is never terrible. Overall, it is slightly better than  Ara-Kara Sacbrood if you manage the stacks well. Ideally for Rider of the Apocalypse, this equates to 15 stacks of both movement and stand still. For San'layn, we want 20 stacks of stand still and 10 stacks of movement.")
                },
                {
                    "Demonology Warlock",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Trinket that grants both Intellect and secondary stats based on movement. The on use effect can be used to suspend your current buffs, though it's not likely you will be actively looking to suspend your buff either way.")
                },
                {
                    "Devastation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Interesting trinket that either gives you intellect when standing still, or your highest secondary stat when moving. Using the trinket will pause the stacks.")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Brings a lot of passive stats and the effect doesn't punish you too much in either the movement or stationary requirements, but still variable enough to be harmed by different fight styles and the need to micro-manage it. The on-use is best done when you have the egg balanced below 20 stacks due to the penalty after.")
                },
                {
                    "Fire Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Interesting trinket that either gives you intellect when standing still, or your highest secondary stat when moving. Using the trinket will pause the stacks.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Powerful passive stat trinket, with movement being used to gain secondary stats, and remaining stationary for Agility. The on-use is best used when the stats are nearly even, while below 20 stacks of either buff.")
                },
                {
                    "Holy Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "A decent stat stick. You will always have 30 stacks combined active, moving causes you to lose main stat but gain secondary. The optimal ratio is 20 intellect stacks and 10 secondary, but it is generally not something you should play around. Just keep in mind to not move around too much.")
                },
                {
                    "Holy Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Primary and Secondary stat buff")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "A strong trinket that requires you to wiggle around a bit to maintain stacks. With Agility and Versatility being similar values this tier, this trinket is quite good. Focus on not going over 20 of either stack and the trinket is great. The on use also ignores double on use restriction.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "The trinket is only good if you are able to stand still, the on-use effect can be used to move once every 120 seconds. The use of this trinket in general is not recommended if you have other passive options.")
                },
                {
                    "Survival Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "This is a bit of an awkward trinket, but on paper it provides a large amount of stats, which scales well into Single Target and AoE alike.")
                },
                {
                    "Affliction Warlock",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Trinket that grants both main and secondary stats based on movement. Can also be \"used\" to suspend your current buffs.")
                },
                {
                    "Arcane Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Simple trinket, try to use it if you have to move a ton so that you maintain the primary stat buff - that said, its not a real issue if you dont.")
                },
                {
                    "Assassination Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "This would be used in your passive slot typically. While min-maxing the buff is possible by standing still, it probably isn't worth it and can be mostly ignored")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Somewhat interesting take on the typical stat stick. You will begin with 30 stacks of Intellect out of combat, and are generally encouraged to maintain a balance of both stacks to maximize overall value.  While I'm not generally keen on effects which restrict mobility on Evoker, minimizing movement should allow you to maintain stacks of Intellect, particularly in certain encounters.")
                },
                {
                    "Balance Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "This trinket grants both Primary and Secondary stats based on movement. It can also be  \"used\" to suspend your current buffs. It's slightly worse than some other options, but not horrible.")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "While this trinket gives no stats on its own, you will passively generate either Agility or your highest secondary stat based on whether you are standing still or moving. This results in building or losing one stack of each buff per second, with the option to freeze the stack counts at their current amounts once every 2-minutes. Overall, you will need to maintain large amounts of the Agility stack count in particular for this trinket to excel, so don't fidget too much! When properly utilized, this trinket represents one of your strongest choices in AoE.")
                },
                {
                    "Elemental Shaman",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "")
                },
                {
                    "Feral Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "A strong trinket but one that is limited in item level to Heroic levels only. At comparable item levels, its one of the best secondary trinket options available.")
                },
                {
                    "Frost Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "This is a complicated trinket, but generally you can just think of it as a passive stat boost. Because stacks above 20 grant a reduced effect, you should try to keep both types of stacks below 20 and use the active to keep it balanced there.")
                },
                {
                    "Guardian Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "This trinket is decent on encounters where you don't have to move too often.")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "This trinket allows you to decide how much Intellect or Haste it gives you, with Intellect's stacks climbing while you stay still and diminishing while moving, while Haste works vice versa. There's a cooldown that allows you to keep your current buff numbers frozen for 20 seconds, but outside of this, you want to try and maintain 20 stacks of Intellect and 10 stacks of Haste. This trinket requires a fair bit of work to optimize, and there are other trinkets that do what it does without needing to track the stacks of two buffs.")
                },
                {
                    "Protection Warrior",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "")
                },
                {
                    "Shadow Priest",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Trinket that grants both main and secondary stats based on movement. Can also be  \"used\" to suspend your current buffs to allow more flexibility.")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "This trinket has no baseline stats. Instead, you generate stacks of either Agility or your highest Secondary stat based on whether you are standing still or moving, at a rate of 1 per second. When you activate the on-use, it will freeze the stack counts at their current amounts for 20 seconds once every 2 minutes. This is pretty annoying to use, so despite the potentially large gain, it loses some value.")
                },
                {
                    "Blood Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "")
                },
                {
                    "Retribution Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "Stacks Strength or a secondary stat depending on whether you're standing still or moving. If possible, you want to maintain 20 stacks of the secondary stat buff and 10 of Strength.")
                },
                {
                    "Windwalker Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_mercurialegg_purple.jpg", "https://wowhead.com/item=220305", "")
                }
            }
        },
        {
            "Quickwick Candlestick", new Dictionary<string, TierModel>
            {
                {
                    "Enhancement Shaman",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "The only thing keeping this out of S tier is the lower item level from Delves. Passive Agility with on demand Haste every 2 minutes that, while also aligning with  Ascendance which is great. Very competitive option even with higher item level alternatives.")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "A decent alternative to Skardyn's Grace, but clearly a step worse.")
                },
                {
                    "Protection Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Arcane Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "A solid use trinket, just held back by lower being ilevel.")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Feral Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "A strong trinket but one that is limited in item level to Heroic levels only. At comparable item levels, its one of the better secondary trinket options available.")
                },
                {
                    "Frost Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "While not available at maximum item level, this is a solid active trinket.")
                },
                {
                    "Holy Priest",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "Delve drop with a haste increase.")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Protection Warrior",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Restoration Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "An on-use Haste trinket to pair with Tree of Life. Not available at max level.")
                },
                {
                    "Restoration Shaman",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "Another decent trinket from Delves. This is beaten out by higher item level trinkets, but fine early in the season if you get your hands on a high item level one.")
                },
                {
                    "Survival Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "This can be a reasonable alternative to  Skardyn's Grace in a pinch, however it is nowhere near as powerful even at 626, which is the maximum itemlevel of  Quickwick Candlestick.")
                },
                {
                    "Windwalker Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Holy Paladin",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "Should simply be used with  Avenging Wrath every 2 minutes.")
                },
                {
                    "Demonology Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Devastation Evoker",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "Moves to A tier in AoE if higher itemlevel. Decent on-use trinket that provides Haste and movement speed, but held back by its low itemlevel.")
                },
                {
                    "Fire Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "Decent on-use trinket that provides Haste and movement speed, but held back by its low itemlevel.")
                },
                {
                    "Preservation Evoker",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "We don't have anything good to combine with a 2 minute on-use trinket.")
                },
                {
                    "Retribution Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "On use Haste buff. Use after  Execution Sentence before  Wake of Ashes.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "Decent trinket from Delves. It is a strong option even if Haste is our weakest secondary stat.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Affliction Warlock",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Discipline Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Frost Death Knight",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_archaeology_candlestub.jpg", "https://wowhead.com/item=225649", "")
                }
            }
        },
        {
            "Refracting Aggression Module", new Dictionary<string, TierModel>
            {
                {
                    "Brewmaster Monk",
                    new TierModel("C+", "https://wow.zamimg.com/images/wow/icons/large/inv_10_engineering2_tinkermodules_color1.jpg", "https://wowhead.com/item=219315", "")
                },
                {
                    "Blood Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_engineering2_tinkermodules_color1.jpg", "https://wowhead.com/item=219315", "")
                },
                {
                    "Protection Warrior",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_engineering2_tinkermodules_color1.jpg", "https://wowhead.com/item=219315", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C-", "https://wow.zamimg.com/images/wow/icons/large/inv_10_engineering2_tinkermodules_color1.jpg", "https://wowhead.com/item=219315", "This trinket has static Agility and whenever you taunt, it grants a shield that reduces damage you take by 50%, up to a cap with a 1 minute ICD. Unfortunately, the size of the shield is extremely low despite being on-demand, and incentivizes taunting for purposes other than regaining aggro.")
                },
                {
                    "Protection Paladin",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_10_engineering2_tinkermodules_color1.jpg", "https://wowhead.com/item=219315", "This is a weak trinket that gives you an absorb when you taunt. This trinket doesn't work in raid at all because timings usually allow for cooldowns to be cycled quickly so the shield is not really needed. In M+, you could have potentially used it to help fill defensive gaps but the shield strength is not enough. It's barely a single melee swing as key levels get higher.")
                }
            }
        },
        {
            "Reinforced-Wax Plating", new Dictionary<string, TierModel>
            {
                {
                    "Brewmaster Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_food_legion_goochocovanilla_pool.jpg", "https://wowhead.com/item=226521", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_food_legion_goochocovanilla_pool.jpg", "https://wowhead.com/item=226521", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_food_legion_goochocovanilla_pool.jpg", "https://wowhead.com/item=226521", "")
                }
            }
        },
        {
            "Satchel of Misbegotten Minions", new Dictionary<string, TierModel>
            {
                {
                    "Elemental Shaman",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coinbag07.jpg", "https://wowhead.com/item=178772", "")
                },
                {
                    "Frost Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coinbag07.jpg", "https://wowhead.com/item=178772", "This is a pretty boring passive damage trinket, but it performs well.")
                },
                {
                    "Affliction Warlock",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coinbag07.jpg", "https://wowhead.com/item=178772", "Trinket provides a baseline amount of Intellect with a damage effect that increases per target hit. Can be worth acquiring before actual BIS is obtained.")
                },
                {
                    "Arcane Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coinbag07.jpg", "https://wowhead.com/item=178772", "Proc damage that goes boom, its not as terrible as it was in Shadowlands!")
                },
                {
                    "Demonology Warlock",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coinbag07.jpg", "https://wowhead.com/item=178772", "With an AoE based effect and passive Intellect, this trinket should be interesting especialy in Mythic+ situations where AoE is typically more relevant. As a passive option, this trinket should be more than suitable.")
                },
                {
                    "Devastation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coinbag07.jpg", "https://wowhead.com/item=178772", "Chance to cause a small explosion that is split between targets, but increases in damage up to 5 targets.")
                },
                {
                    "Shadow Priest",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coinbag07.jpg", "https://wowhead.com/item=178772", "Trinket provides a baseline intellect but with a damage effect that increases per target hit. It's a fine direct damage option, though nothing to target or aim for generally.")
                },
                {
                    "Balance Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coinbag07.jpg", "https://wowhead.com/item=178772", "")
                },
                {
                    "Destruction Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coinbag07.jpg", "https://wowhead.com/item=178772", "")
                },
                {
                    "Fire Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coinbag07.jpg", "https://wowhead.com/item=178772", "Chance to cause a small explosion that is split between targets, but increases in damage up to 5 targets.")
                }
            }
        },
        {
            "Scrapsinger's Symphony", new Dictionary<string, TierModel>
            {
                {
                    "Holy Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_blacksmithing_craftedoptional_engineering_color1.jpg", "https://wowhead.com/item=219302", "Intellect trinket with a solid shield effect. Random but effective!")
                },
                {
                    "Preservation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_10_blacksmithing_craftedoptional_engineering_color1.jpg", "https://wowhead.com/item=219302", "")
                },
                {
                    "Restoration Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_10_blacksmithing_craftedoptional_engineering_color1.jpg", "https://wowhead.com/item=219302", "")
                },
                {
                    "Holy Paladin",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_10_blacksmithing_craftedoptional_engineering_color1.jpg", "https://wowhead.com/item=219302", "")
                },
                {
                    "Discipline Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_blacksmithing_craftedoptional_engineering_color1.jpg", "https://wowhead.com/item=219302", "Intellect trinket with a solid shield effect. Random but effective!")
                },
                {
                    "Restoration Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_blacksmithing_craftedoptional_engineering_color1.jpg", "https://wowhead.com/item=219302", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_blacksmithing_craftedoptional_engineering_color1.jpg", "https://wowhead.com/item=219302", "")
                }
            }
        },
        {
            "Scroll of Momentum", new Dictionary<string, TierModel>
            {
                {
                    "Outlaw Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_scroll3_color2.jpg", "https://wowhead.com/item=226539", "An incredibly strong trinket that is held down by the fact you can't increase to a higher reward track. It's a perfect trinket to chase down early in the tier, but it will fall off as you get Mythic gear. Make sure to use  Sprint every time it procs. Movement is not required; it just requires high movement speed.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_scroll3_color2.jpg", "https://wowhead.com/item=226539", "You can use  Sprint offensively for extra output.")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_scroll3_color2.jpg", "https://wowhead.com/item=226539", "This is technically a DPS trinket, so it suffers from the 33% damage penalty to non-Tanks, and since it comes from Delves, its maximum item level is only 626. Despite this, because the damage based on movement speed increase portion applies to all increases, including those from our talents, this trinket is actually still decent.")
                },
                {
                    "Assassination Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_scroll3_color2.jpg", "https://wowhead.com/item=226539", "Does decent damage but you need to use  Sprint to get the most out of the effect. Very awkward trinket to use")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_scroll3_color2.jpg", "https://wowhead.com/item=226539", "")
                },
                {
                    "Feral Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_scroll3_color2.jpg", "https://wowhead.com/item=226539", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_scroll3_color2.jpg", "https://wowhead.com/item=226539", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_scroll3_color2.jpg", "https://wowhead.com/item=226539", "")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_scroll3_color2.jpg", "https://wowhead.com/item=226539", "")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_scroll3_color2.jpg", "https://wowhead.com/item=226539", "")
                },
                {
                    "Survival Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_scroll3_color2.jpg", "https://wowhead.com/item=226539", "Possibly interesting. it is currently unclear how much the damage effect scales with speed effects. However, given how far down its performance currently is i doubt that even  Aspect of the Cheetah could make up for it.")
                }
            }
        },
        {
            "Shadow-Binding Ritual Knife", new Dictionary<string, TierModel>
            {
                {
                    "Assassination Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "A surprisingly strong delve trinket, but the item level keeps it down compared to the higher listed trinkets")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "This trinket is essentially an overbudget Intellect + Mastery stat stick with a downside that procs infrequently. Overall this trinket is quite good for Augmentation. The only major caveat is that, as usual, Delve trinkets can only be obtained at Hero track via the Great Vault, and cannot reach Myth track like items from Raid or Mythic+. This is still a solid trinket overall, even at lower item levels.")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "Brings a huge amount of passive stats, and the negative proc of stat reduction happens very infrequently making its high budget work it. Even at lower item levels the budget on this makes it keep up with higher item level alternatives, plus you can't really mess up stat sticks.")
                },
                {
                    "Frost Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "")
                },
                {
                    "Holy Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "Strong mastery and primary stat buff")
                },
                {
                    "Retribution Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "Passive statstick. No special usage required.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "Best Delves trinket, has a high uptime.")
                },
                {
                    "Survival Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "Very powerful, passive trinket. It does reduce your secondary stats randomly, which can impact you in important damage phases, but most of the time it reduces an unimportant stat (versatility or critical strike). However, this trinket is limited in power due to only being obtainable at a high ilevel through the great vault or specifically Delve maps.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "A passive trinket that can be quite strong if obtained at high item levels through the Great Vault. Generally worse than  Ara-Kara Sacbrood.")
                },
                {
                    "Restoration Shaman",
                    new TierModel("B+", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "")
                },
                {
                    "Arcane Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "A stronger passive trinket from delves, don't worry about the stats you lose, it balances out in the long run.")
                },
                {
                    "Feral Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "A strong trinket but one that is limited in item level to Heroic levels only. At comparable item levels, its one of the best secondary trinket options available.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "")
                },
                {
                    "Destruction Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "")
                },
                {
                    "Discipline Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_knife_1h_grimbatolraid_d_03.jpg", "https://wowhead.com/item=215178", "")
                }
            }
        },
        {
            "Shining Arathor Insignia", new Dictionary<string, TierModel>
            {
                {
                    "Outlaw Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_arathorhandtorch01.jpg", "https://wowhead.com/item=225647", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_arathorhandtorch01.jpg", "https://wowhead.com/item=225647", "")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_arathorhandtorch01.jpg", "https://wowhead.com/item=225647", "")
                }
            }
        },
        {
            "Sikran's Endless Arsenal", new Dictionary<string, TierModel>
            {
                {
                    "Outlaw Rogue",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "A strong general use trinket. One of the weapons does massive AoE damage. Make sure to use this trinket on cooldown, it's short cooldown will help you cycle to the AoE option quickly.")
                },
                {
                    "Blood Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", " Stance - Surekian Decimation - On-use frontal line AoE; passive causes your crits to deal 20% bonus damage to shields.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "Technically a Tank/Melee Trinket, but its on-use has no range limitation and does excellent single-target damage.")
                },
                {
                    "Protection Warrior",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "Has several beneficial on-use effects which stack up to do a decent amount of damage and grant some nice passive defensive elements.")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "Similar to  Cache of Acquired Treasures, this trinket has three weapons it cycles through. It cycles between an AoE cone, a single target DoT, and a split damage frontal. It's a little annoying to play around and optimize, but pressing it on cooldown works fine, and it does decent damage especially in AoE situations")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "")
                },
                {
                    "Feral Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "Much stronger on AoE than on single-target.")
                },
                {
                    "Guardian Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "This provides a mediocre on-use effect on a short cooldown.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "")
                },
                {
                    "Survival Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "This trinket has incredibly random but fun effects, although they aren't incredibly potent they do offer some bonus niche effects such as avoidance and run speed.")
                },
                {
                    "Windwalker Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "")
                },
                {
                    "Frost Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "An Arsenal trinket with a twist - this time it not only deals damage, but also provides some defensive power alongside it. Great for when you want to do decent damage and also need a bit more staying power.")
                },
                {
                    "Retribution Paladin",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_sikransarsenal_purple.jpg", "https://wowhead.com/item=212449", "")
                }
            }
        },
        {
            "Silken Chain Weaver", new Dictionary<string, TierModel>
            {
                {
                    "Blood Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_tailoring_purchasedthread_color2.jpg", "https://wowhead.com/item=215172", "Specifically great for Mythic+ as a defensive; the attack speed reduction is disgusting, extremely long duration, and up for every big pull.")
                },
                {
                    "Protection Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_tailoring_purchasedthread_color2.jpg", "https://wowhead.com/item=215172", "")
                },
                {
                    "Protection Warrior",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_tailoring_purchasedthread_color2.jpg", "https://wowhead.com/item=215172", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_10_tailoring_purchasedthread_color2.jpg", "https://wowhead.com/item=215172", "This trinket may have a reduced maximum item level due its source being Delves, but its defensive effect remains one of the most potent available for dungeons due to its attack speed reduction on enemies affected by the on-use. Be aware that it will not be as effective on higher-level enemies such as bosses or minibosses, however!")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_10_tailoring_purchasedthread_color2.jpg", "https://wowhead.com/item=215172", "This trinket is a purely defensive option in Mythic+, with a 15% attack speed reduction for 15 seconds on an extremely short 1 minute cooldown, while also granting a small shield. The shield isn't particularly good, but 25% uptime on the largest source of damage intake that is available for every pull is fantastic. Unfortunately, coming from Delves, it has a maximum item level of 626.")
                }
            }
        },
        {
            "Siphoning Lightbrand", new Dictionary<string, TierModel>
            {
                {
                    "Brewmaster Monk",
                    new TierModel("C+", "https://wow.zamimg.com/images/wow/icons/large/70_inscription_vantus_rune_light.jpg", "https://wowhead.com/item=225653", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C+", "https://wow.zamimg.com/images/wow/icons/large/70_inscription_vantus_rune_light.jpg", "https://wowhead.com/item=225653", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/70_inscription_vantus_rune_light.jpg", "https://wowhead.com/item=225653", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/70_inscription_vantus_rune_light.jpg", "https://wowhead.com/item=225653", "")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/70_inscription_vantus_rune_light.jpg", "https://wowhead.com/item=225653", "")
                }
            }
        },
        {
            "Siphoning Phylactery Shard", new Dictionary<string, TierModel>
            {
                {
                    "Holy Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_enchanting_70_chaosshard.jpg", "https://wowhead.com/item=178783", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_enchanting_70_chaosshard.jpg", "https://wowhead.com/item=178783", "")
                },
                {
                    "Discipline Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_enchanting_70_chaosshard.jpg", "https://wowhead.com/item=178783", "")
                },
                {
                    "Holy Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_enchanting_70_chaosshard.jpg", "https://wowhead.com/item=178783", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_enchanting_70_chaosshard.jpg", "https://wowhead.com/item=178783", "")
                },
                {
                    "Preservation Evoker",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_enchanting_70_chaosshard.jpg", "https://wowhead.com/item=178783", "")
                },
                {
                    "Restoration Druid",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_enchanting_70_chaosshard.jpg", "https://wowhead.com/item=178783", "")
                }
            }
        },
        {
            "Skardyn's Grace", new Dictionary<string, TierModel>
            {
                {
                    "Assassination Rogue",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=133282", "This is our BiS on-use trinket hands down. Mastery is a good stat, it's easy to use, lines up with all our cooldowns. What more could you want?")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=133282", "")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=133282", "Provides passive Agility and a large on-demand Mastery boost. Thanks to Patch 11.0.5 now also always aligns with  Ascendance, so is by far our best option. This is thanks to our Mastery being a force multiplier to begin, and our burst already being exceptional.")
                },
                {
                    "Feral Druid",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=133282", "The best stat on-use trinket available. It lines up with our cooldowns and provides a huge chunk of a powerful stat.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=133282", "Havoc's second strongest on-use trinket, lining up with  Metamorphosis causes this trinket to be BiS for AoE scenarios IF you will not play  Treacherous Transmitter.")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=133282", "The best all-rounder Trinket for Sentinel. Can be macro'd to  Trueshot.")
                },
                {
                    "Survival Hunter",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=133282", "This can be a reasonable alternative to  Skardyn's Grace in a pinch, however it is nowhere near as powerful even at 626, which is the maximum itemlevel of  Quickwick Candlestick.")
                },
                {
                    "Windwalker Monk",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=133282", "The best trinket that doesn't come from Raid, since it escaped the first round of trinket tuning. Mastery isn't as plentiful currently as in the past, so getting a big chunk of it is *chef's kiss*.")
                },
                {
                    "Guardian Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=133282", "Provides a large amount of mastery that we can line up well with  Incarnation: Guardian of Ursoc/ Rage of the Sleeper or  Lunar Beam.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=56440", "The on-use nature of this trinket's (massive) Mastery buff results in it being an acceptable choice for both damage and defense. It being perhaps the second-best defensive trinket of the season says a lot about your available options.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=133282", "Mastery is our best stat, good option for Mythic+ and okay alternative for your active trinket.")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_coin_08.jpg", "https://wowhead.com/item=56440", "This trinket grants static Agility and a huge Mastery buff for 20 seconds on a 2 minute cooldown. Sadly, Mastery is not very good.")
                }
            }
        },
        {
            "Skarmorak Shard", new Dictionary<string, TierModel>
            {
                {
                    "Frost Death Knight",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color2.jpg", "https://wowhead.com/item=219300", "Both on-use secondary stat trinkets available for Frost this season are nearly identical.  Skarmorak Shard grants small Mastery buffs when you defeat enemies, making this a bit more attractive than  Mark of Khardros in Mythic+. The 90-second cooldown makes this trinket worthwhile for any build. It will line up with your cooldowns whether you play Deathbringer or Rider of the Apocalypse,  Breath of Sindragosa or  Obliteration.")
                },
                {
                    "Retribution Paladin",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color2.jpg", "https://wowhead.com/item=219300", "On use Mastery trinket. Use after  Execution Sentence before  Wake of Ashes.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color2.jpg", "https://wowhead.com/item=219300", "Another great on-use trinket with a 90-second cooldown. Very similar to  Mark of Khardros, but gives slightly less Mastery on use. As compensation, it also grants you a little Mastery when walking near an enemy's corpse. This secondary effect makes this trinket great for Mythic+ and Delves.")
                },
                {
                    "Protection Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color2.jpg", "https://wowhead.com/item=219300", "A mastery on-use that is much better in M+ or AoE where you're killing mobs for the secondary part. In single target this is worse than the other Mastery on-use option.")
                },
                {
                    "Protection Warrior",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color2.jpg", "https://wowhead.com/item=219300", "")
                },
                {
                    "Blood Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_arathordungeon_fragment_color2.jpg", "https://wowhead.com/item=219300", "")
                }
            }
        },
        {
            "Skyterror's Corrosive Organ", new Dictionary<string, TierModel>
            {
                {
                    "Blood Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_oversizedacidgland_green.jpg", "https://wowhead.com/item=212453", "")
                },
                {
                    "Frost Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_oversizedacidgland_green.jpg", "https://wowhead.com/item=212453", "A solid option for both Mythic+ and Raid. The splash range is short, so make sure enemies are gathered before using this trinket. The DoT applied by the trinket will intensify once per tick, so there is no need to force extra damage ticks while the trinket is active.")
                },
                {
                    "Protection Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_oversizedacidgland_green.jpg", "https://wowhead.com/item=212453", "")
                },
                {
                    "Protection Warrior",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_oversizedacidgland_green.jpg", "https://wowhead.com/item=212453", "")
                },
                {
                    "Retribution Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_oversizedacidgland_green.jpg", "https://wowhead.com/item=212453", "On use damage. Use on cooldown.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_oversizedacidgland_green.jpg", "https://wowhead.com/item=212453", "As expected from a damage-effect trinket, it's not the best for Unholy. That said, it still deals good damage, more so in AoE scenarios.")
                }
            }
        },
        {
            "Smoldering Howler Horn", new Dictionary<string, TierModel>
            {
                {
                    "Unholy Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_corehoundsmall_orange.jpg", "https://wowhead.com/item=205201", "On-use stat trinket that aligns well with your 90-second cooldown windows. The fact that it grants Critical Strike does hold this back a bit, compared to a Haste or Mastery trinket with the same same cooldown.")
                }
            }
        },
        {
            "Spare Meat Hook", new Dictionary<string, TierModel>
            {
                {
                    "Protection Warrior",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_archaeology_70_tauren_moosebonefishhook.jpg", "https://wowhead.com/item=178751", "")
                },
                {
                    "Blood Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_archaeology_70_tauren_moosebonefishhook.jpg", "https://wowhead.com/item=178751", "Point and shoot, just don't outrange the effect.")
                },
                {
                    "Frost Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_archaeology_70_tauren_moosebonefishhook.jpg", "https://wowhead.com/item=178751", "One of the better placeholders until you can get something better. A solid Strength stick with an okay damage on-use effect.")
                },
                {
                    "Retribution Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_archaeology_70_tauren_moosebonefishhook.jpg", "https://wowhead.com/item=178751", "On use damage. Use on cooldown. Try to stay close enough to the target so that it won't break early.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_archaeology_70_tauren_moosebonefishhook.jpg", "https://wowhead.com/item=178751", "Solid on-use damage trinket with a slow component. Not the best out there for Unholy due to the spec's preferences toward stats, but if it's the best you have then it's a solid option.")
                },
                {
                    "Protection Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_archaeology_70_tauren_moosebonefishhook.jpg", "https://wowhead.com/item=178751", "")
                }
            }
        },
        {
            "Spelunker's Waning Candle", new Dictionary<string, TierModel>
            {
                {
                    "Frost Death Knight",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("B+", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "While we don't normally look for Crit on gear, since we're melee the chance you can double this buff up on an ally makes it extremely valuable for overall group damage. Less beneficial purely for us, but the net benefit makes it worth it.")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Blood Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "It is an okay trinket that comes with a stat proc, also provides a buff to your group.")
                },
                {
                    "Protection Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Protection Warrior",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "One of the better Delve passive trinkets, the crit proc is tuned fairly well, but it does suffer from the lower item level")
                },
                {
                    "Feral Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "")
                },
                {
                    "Survival Hunter",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_purple.jpg", "https://wowhead.com/item=225638", "Another delve trinket, aiming more at potentionally buffing allies. However, unlike  Mistcaller Ocarina it appears to split the buff with your ally rather than getting the full effect. This means you might not want to share the buff at all if you happen to have your cooldowns active! As with all Delve trinkets, the maximum itemlevel is limited at 626.")
                }
            }
        },
        {
            "Spymaster's Web", new Dictionary<string, TierModel>
            {
                {
                    "Demonology Warlock",
                    new TierModel("S+", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "Our strongest trinket option; not only does it provide an OK stat passively, you gain passive Intellect and the ability to have a strong on use for specific burn phases, be careful however as the stacking Intellect takes some time to ramp.")
                },
                {
                    "Affliction Warlock",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "Strong trinket with a main stat stacking effect and an on-use that accrues value passively.")
                },
                {
                    "Arcane Mage",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "This trinket is incredibly powerful due to how flexible it is, not using it at all is also not even that bad due to the stacking buff. Overall we'll aim to collect stacks on this until execute phases, then use our cooldowns with it for huge damage. If the fight is long enough, try to stagger using it such that you get full stacks in execute, but also don't let stacks go to waste. Make sure you save your potion and other cooldowns to use with this in execute!")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "One of the strongest trinkets available to casters for progression content. Passive Mastery benefits Augmentation's stat priority, but the secondary effect is where this trinket shines. While it takes some time to ramp up in value, and is less effective immediately on pull or in short encounters, this trinket is an absolute powerhouse for difficult progression encounters. Use this trinket during your  Breath of Eons cooldown window every 4 minutes for a massive burst window.")
                },
                {
                    "Balance Druid",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "A minigame trinket. This can be obnoxious, depending on what buff you get. Double on-use with this and  Spymaster's Web is quite strong. Download this weakaura to help play with this trinket to maximum effectiveness: https://wago.io/jX4s-GYvb")
                },
                {
                    "Destruction Warlock",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "The strongest trinket option overall. Grants a good amount of intellect, and has a good on-use effect that works well with Destructions damage profile. Read the below segment on Spymaster's usage to know how I recommend you optimally use this trinket.")
                },
                {
                    "Devastation Evoker",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "By far our best trinket. Flexible on-use trinket that functions as a stat stick and a powerful steroid. Generally, we stack this buff until damage increases or execute phases. Dying removes your stacks, so beware!")
                },
                {
                    "Discipline Priest",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "Provides a stacking intellect buff that you can consume. Your goal is to consume this around every 1.5mins with  Evangelisms cooldown for your ramps in a raid.")
                },
                {
                    "Elemental Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "")
                },
                {
                    "Fire Mage",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "By far our best trinket. Flexible on-use trinket that functions as a stat stick and a powerful steroid. Generally, we stack this buff until damage increases or execute phases. Dying removes your stacks, so beware!")
                },
                {
                    "Frost Mage",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "This is a good active trinket that can be paired with  Icy Veins. Note that if you have a  Spymaster's Web, you can still use this trinket to decent effect because you will not be using  Spymaster's Web very often.")
                },
                {
                    "Preservation Evoker",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "Spymaster's Web is a powerful trinket that we'll combine with  Stasis to improve our burst healing. It's a little less powerful on us than some other healers but is still powerful enough to belong in S tier. Note that it does require you keep  Fire Breath active.")
                },
                {
                    "Restoration Druid",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "Spymaster's Web is the perfect compliment to our frequent ramps. It puts our power where we need it the most. You'll use it either every minute or every two minutes depending on what is more useful to the fight. The downside is you do need to keep a  Moonfire active on the boss.  Grove Guardians will take care of some of them, but you'll need to cast the rest. If you aren't good with  Moonfire uptime then this trinket isn't very good. It's also quite a bit worse in Mythic+.")
                },
                {
                    "Restoration Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "A very strong stat-stick that can be used whenever you need additional healing. The only requirement is to regularly keep  Flame Shock active to generate stacks of the trinket.")
                },
                {
                    "Shadow Priest",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "Strong trinket with main stat stacking effect and an on-use that accrues value passively, this is excellent for using alongside major cooldowns and at difficult parts of a boss or dungeon.")
                },
                {
                    "Holy Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "The on-use effect should be used with your Wings. To gain the optimal effect of this trinket, you need to cast an offensive spell every 6 seconds. If you do not come close to proccing it on that 6 second cooldown, it loses a ton of value. In dungeons this is not a problem as you will be having  Consecration down permanently. In raids, it loses a lot of value as you will not be proccing it every 6 seconds consistently, unless you keep  Consecration down, which isn't worth it.")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_raid_spymastersweb_purple.jpg", "https://wowhead.com/item=220202", "With a recent change to what triggers this trinket, it's now one of our best trinkets, provided we use a damaging ability every 6 seconds. This makes sure that the stacks of the buff continually grow. Because we don't have any periodic damaging spells, we need to make sure we cast  Tiger Palm,  Blackout Kick, or  Rising Sun Kick every 6 seconds while in combat. Pair the activated effect with any of our cooldowns to make your healing during them even more effective!")
                }
            }
        },
        {
            "Sturdy Deepflayer Scute", new Dictionary<string, TierModel>
            {
                {
                    "Unholy Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_misc_food_legion_seashellf2.jpg", "https://wowhead.com/item=205193", "On-use stat trinket that aligns well with your 90-second cooldown windows. The fact that it grants Versatility does hold this back a bit, compared to a Haste or Mastery trinket with the same same cooldown.")
                }
            }
        },
        {
            "Swarmlord's Authority", new Dictionary<string, TierModel>
            {
                {
                    "Vengeance Demon Hunter",
                    new TierModel("A+", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_swarmlordsauthority_purple.jpg", "https://wowhead.com/item=212450", "This trinket has static Haste and a 3+Haste RPPM proc that summons a pet, which deals damage and grants a 50% absorb shield. In addition, it has a 1 minute cooldown on-use which summons 12+Haste scarabs over 3 seconds that each do the same as the random procs. Effectively, it's equivalent to 15+Haste procs per minute, making it our strongest defensive trinket available.")
                },
                {
                    "Guardian Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_swarmlordsauthority_purple.jpg", "https://wowhead.com/item=212450", "Great Haste passive with a fairly strong defensive healing bonus.")
                },
                {
                    "Protection Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_swarmlordsauthority_purple.jpg", "https://wowhead.com/item=212450", "This is an absorption trinket with an on-use that scales with Haste. The on-use has a slight delay so with good planning, you will get a nice absorb shield that will give some damage smoothing on top of some smoothing from passive absorbs.")
                },
                {
                    "Blood Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_swarmlordsauthority_purple.jpg", "https://wowhead.com/item=212450", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_swarmlordsauthority_purple.jpg", "https://wowhead.com/item=212450", "The static Haste present on this trinket immediately hinders its total defensive potential, just as the damage from the scarabs being Physical greatly hinders its offensive power (due to being reduced by enemy Armor). However, the short 1-minute cooldown on its on-use effect does translate to a reliable source of potent mitigation when you are in need of it.As for its Haste-based bonus, you will send approximately one additional scarab per 10% of Haste, including Haste from temporary bonuses like  Veteran's Eye or  Bloodlust.")
                },
                {
                    "Protection Warrior",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_swarmlordsauthority_purple.jpg", "https://wowhead.com/item=212450", "Provides an insignificant amount of damage output and a mediocre trickle absorb effect, but won't protect you from dangerous things at all hits instead will just look moderately large on details.")
                }
            }
        },
        {
            "Throngus's Finger", new Dictionary<string, TierModel>
            {
                {
                    "Protection Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_gizmo_felironshell.jpg", "https://wowhead.com/item=133291", "This is a large amount of passive dodge that will proc on cooldown, especially in Mythic+.")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_gizmo_felironshell.jpg", "https://wowhead.com/item=133291", "Despite granting static Versatility, this trinket grants a 20 sec Dodge buff once per minute, which can be a large amount of damage reduction over the course of a Mythic+ dungeon due to the melees avoided. It has roughly 33% uptime.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_gizmo_felironshell.jpg", "https://wowhead.com/item=133291", "")
                }
            }
        },
        {
            "Treacherous Transmitter", new Dictionary<string, TierModel>
            {
                {
                    "Balance Druid",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "A minigame trinket. This can be obnoxious, depending on what buff you get. Double on-use with this and  Spymaster's Web is quite strong. Download this weakaura to help play with this trinket to maximum effectiveness: https://wago.io/jX4s-GYvb")
                },
                {
                    "Elemental Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Frost Death Knight",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "A highly unique trinket that outpaces the competition when used properly. When you use it, you will get one of three tasks: stand on a plate, collect an orb, or jump three times. We want to complete the task right before using  Pillar of Frost. The \"stand here\" and \"catch the ball\" tasks can be done by running to a spot a few steps forward and right from where you used the trinket. Learning this spot will be key to good timing on lining up the buff with  Pillar of Frost. Consider this more strongly for Mythic+, where you can start the task before pulling a pack. Rider of the Apocalypse builds especially want this trinket, because the Strength buff will empower all the Horsemen. In contrast, the Mastery buff from the other on-use trinkets will do little for the Horsemen.")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "The best all-rounder Trinket for Dark Ranger.")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "The best trinket for your 2nd trinket slot but a very contested trinket option.If you get this trinket, use it during  Symbols of Death as TricksterUse it during  Lingering Darkness when playing DeathstalkerIf combined with other on use trinkets like  Treacherous Transmitter, use  Mad Queen's Mandate second.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "Unholy's strongest on-use trinket option, though it does come with some downsides in that the tasks it gives to complete can be hard to execute at times. This adds an element of risk when using it, and if you can't comfortably adjust to these requirements then consider opting for one of the other on-use alternatives.")
                },
                {
                    "Windwalker Monk",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "This trinket gives huge Haste and even bigger Agility. All you have to do is successfully complete a task that can range from the easy to the frustrating. If you can stand to play with that then this trinket is incredibly strong and is a requirement if you want to play Conduit of the Celestials for big burst every 90 seconds.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("S-", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "Treacherous Transmitter sims incredibly well as one of Havoc Demon Hunter's best trinket options, however actually using this trinket is a bit of a bait and I recommend keeping away if you are not confident in your ability to play around it efficiently. It forces you to do one of three different tasks, which are finding a moving purple orb, standing on a pad that spawns away from you for 3 seconds, or jumping 3 times. All of these take differing amounts of time to perform during your opener, and can be hard to spot.")
                },
                {
                    "Arcane Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "Blizzard was quick to fix this trinket so we could not use it with Spymaster's, however it is still strong, aim to use it 6-7s before  Evocation, then activate the buff when you're ready to burst!")
                },
                {
                    "Feral Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "The second best stat on-use trinket available, and the best one from the raid. It doesn't line up with your cooldowns as perfectly as other options, so you'll usually need to hold it for 30 seconds to sync it. The minigames it requires can be a little annoying to fully take advantage of, but it's still a strong option.")
                },
                {
                    "Fire Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "On-use trinket that gives you instructions that provide intellect on completion. This trinket is a bit of a hassle, but you can stagger the buff to make it last longer.")
                },
                {
                    "Shadow Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "This trinket provides an on use damage effect every 90 seconds after the perform a simple task such as jump or collect an orb. Unfortunately at 90 seconds this does not line up well with any of our cooldowns.")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("B+", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "While this brings passive Haste and a huge amount of stats when used, it has the downside of being incredibly annoying to play around based on which minigame you get. The cooldown is also now desynced with  Ascendance in Patch 11.0.5 which hurts its value, but it does provide an on-use alternative if you can't get something better.")
                },
                {
                    "Devastation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "On-use trinket that gives you instructions that provide intellect on completion. This trinket is a bit of a hassle, but you can stagger the buff to make it last longer.")
                },
                {
                    "Frost Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "This is a good active trinket that can be paired with  Icy Veins. Note that if you have a  Spymaster's Web, you can still use this trinket to decent effect because you will not be using  Spymaster's Web very often.")
                },
                {
                    "Guardian Druid",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "Grants a large amount of our Primary stat for a short period, but requires  you to execute some sort of puzzle task such as jumping 3 times or chasing an orb. Can be detrimental, depending on when you use it.")
                },
                {
                    "Protection Warrior",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "Grants extremely high amount of Strength on a 1.5-minute cooldown. However is locked behind a small series of gimmicks to perform like \"Jump 3 times!\" or \"collect these orbs\" before getting its buff. Otherwise a very potent trinket!")
                },
                {
                    "Retribution Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "On use Strength buff. It requires you to make follow directions, making specific movements to get it. Use early enough that you'll have the buff active before  Wake of Ashes.")
                },
                {
                    "Survival Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "A fairly versatile and strong trinket, but the tasks can be a little tedious or restrictive, requiring you to chase an orb, jump a few times, or to stand in a purple zone. These tasks are especially restrictive in Mythic+, where the trinket performs best.")
                },
                {
                    "Affliction Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Assassination Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "While this trinket sims as one of the best available from any content, the mini-games you have to do to get the buff makes this the worst trinket imaginable. They've made it easier since beta and the minigames are consistent positioning wise, but it remains completely unusable in any challenging environment. It's by far the worst trinket I have ever played with and only ranks this highly because the buff itself is still quite good.")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "The on-use Intellect of this trinket is reasonable, but the 90 sec cooldown leaves budget on the table for a 2 min spec like Augmentation, and the tasks can be a bit distracting while in combat.")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Blood Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Destruction Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Discipline Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Holy Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "You will be assigned one of three tasks when using this trinket. You will either have to jump 3 times, run over a small orb on the ground, or stand in a portal on the ground. Accomplishing the task grants you a decent bit of intellect for 15 seconds.")
                },
                {
                    "Holy Priest",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Preservation Evoker",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "This trinket will ask you to jump in place or run on top of a portal. It can be very awkward but doing it gives a lot of strength. This trinket does have use cases in raid situations where you have little movement.")
                },
                {
                    "Restoration Druid",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "Jump 3 times.")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                },
                {
                    "Demonology Warlock",
                    new TierModel("F", "https://wow.zamimg.com/images/wow/icons/large/inv_etherealraid_communicator_color1.jpg", "https://wowhead.com/item=221023", "")
                }
            }
        },
        {
            "Twin Fang Instruments", new Dictionary<string, TierModel>
            {
                {
                    "Marksmanship Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "Third Cast: Activates both the prior casts at the same time.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("B-", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("C+", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "")
                },
                {
                    "Survival Hunter",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "Can deal a respectable amount of burst damage, but its use effect awkwardly conflicts with that of other on-use trinkets.")
                },
                {
                    "Assassination Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "")
                },
                {
                    "Feral Druid",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "")
                },
                {
                    "Windwalker Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_11_0_dungeon_fancybox_purple.jpg", "https://wowhead.com/item=219319", "")
                }
            }
        },
        {
            "Unbound Changeling", new Dictionary<string, TierModel>
            {
                {
                    "Elemental Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "")
                },
                {
                    "Holy Priest",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "Excellent stat trinket, uses food buffs to change stat buff. Holy prefers crit or mastery.")
                },
                {
                    "Preservation Evoker",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "Changeling is a classic, but powerful stat stick. The secondary it procs will change based on the food you eat. We will be looking for the mastery proc.")
                },
                {
                    "Restoration Druid",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "Another solid haste stat stick on a decent uptime. Ends up being a slightly less consistent version of Gale of Shadows.")
                },
                {
                    "Restoration Shaman",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "This is a unique stat-stick that allows you to customize which secondary stat it procs by the food that you eat. This makes it very versatile, and it's also fairly easy to get since it comes from Mythic+.")
                },
                {
                    "Affliction Warlock",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "Unbound Changeling can proc a random secondary stat, but also has a chance to \"change\" into a version that grants ALL secondary stats, this chance can occur the first time you eat food in-game for the day.")
                },
                {
                    "Arcane Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "A very strong passive trinket, not as good as other options but a bit more customizable to your character's needs.")
                },
                {
                    "Balance Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "This is a strong, passive Secondary stat trinket. Can be farmed from the Mists of Tirna Scithe dungeon.")
                },
                {
                    "Demonology Warlock",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "Unbound Changeling can proc a random secondary stat, but also has a chance to \"change\" into a version that grants ALL secondary stats, this chance can occur the first time you eat food that gives stats for the day. Given our neutral position on secondary stats, this is a fine option.")
                },
                {
                    "Destruction Warlock",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "Passive intellect and a secondary stat buff. Can be very good. We're especially interested in haste, mastery and crit buffs. The all stat buff is also decent.")
                },
                {
                    "Devastation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "Strong passive trinket. The stats this trinket provides can be customizable to your character's needs. See item for more information.")
                },
                {
                    "Discipline Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "Excellent stat trinket, uses food buffs to change stat buff. Discipline prefers to set to haste.")
                },
                {
                    "Frost Mage",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "This trinket is unusual in that you can choose which stats it provides. Generally, you will probably want the Haste or Mastery version, but it's best to simulate your character to see which is the best for you.")
                },
                {
                    "Holy Paladin",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "A simple proc trinket that will always work well. Procs stat based on the latest secondary food buff you consumed.")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "With this trinket set to Haste, it's one of the best options we could hope for in raids. Similar to  Gale of Shadows, this is just a great passive trinket that increases our Intellect and Haste.")
                },
                {
                    "Shadow Priest",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "Unbound Changeling can proc a random secondary stat, but also has a chance to \"change\" into a version that grants ALL secondary stats, this chance can occur the first time you eat food in-game for the day.")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "A more traditional stat stick design from this Shadowlands favourite, with Augmentation Evokers appreciating the passive Intellect. Eat for Mastery or Critical Strike to change the secondary stat proc based on your personal stat distribution.")
                },
                {
                    "Fire Mage",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_pet_spectralporcupinered.jpg", "https://wowhead.com/item=178708", "Strong passive trinket. The stats this trinket provides can be customizable to your character's needs. See item for more information.")
                }
            }
        },
        {
            "Unstable Power Suit Core", new Dictionary<string, TierModel>
            {
                {
                    "Preservation Evoker",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_spiritshard_01.jpg", "https://wowhead.com/item=225668", "Unstable Power Source isn't available at max item level which keeps it from S-tier. It's a decent early pickup though.")
                },
                {
                    "Restoration Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_spiritshard_01.jpg", "https://wowhead.com/item=225668", "Unstable Power Source isn't available at max item level which holds it back from being a top tier trinket. It's otherwise a very consistent, very decent early trinket to pick up.")
                },
                {
                    "Restoration Shaman",
                    new TierModel("B+", "https://wow.zamimg.com/images/wow/icons/large/inv_spiritshard_01.jpg", "https://wowhead.com/item=225668", "A decent stat-stick, and one of the the only really notable trinkets from Delves.")
                },
                {
                    "Discipline Priest",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_spiritshard_01.jpg", "https://wowhead.com/item=225668", "We believe this is a delve drop that is higher tuned than most.")
                },
                {
                    "Holy Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_spiritshard_01.jpg", "https://wowhead.com/item=225668", "")
                },
                {
                    "Holy Priest",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_spiritshard_01.jpg", "https://wowhead.com/item=225668", "We believe this is a delve drop that is higher tuned than most.")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_spiritshard_01.jpg", "https://wowhead.com/item=225668", "")
                },
                {
                    "Arcane Mage",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_spiritshard_01.jpg", "https://wowhead.com/item=225668", "Another good passive trinket from delves, notice a trend here?")
                },
                {
                    "Demonology Warlock",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_spiritshard_01.jpg", "https://wowhead.com/item=225668", "")
                },
                {
                    "Augmentation Evoker",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_spiritshard_01.jpg", "https://wowhead.com/item=225668", "While technically usable as an Intellect stat stick, the random nature of the secondary effect leaves too much to be desired to consider using this over available alternatives. Additionally, as a Delve trinket this is not available at the highest item level unlike alternatives from Raid or Mythic+.")
                }
            }
        },
        {
            "Vengeful Fire Spirit", new Dictionary<string, TierModel>
            {
                {
                    "Subtlety Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/spell_fire_lavaspawn.jpg", "https://wowhead.com/item=219014", "")
                }
            }
        },
        {
            "Vile Vial of Kaheti Bile", new Dictionary<string, TierModel>
            {
                {
                    "Mistweaver Monk",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_potiond2.jpg", "https://wowhead.com/item=225891", "")
                },
                {
                    "Discipline Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_potiond2.jpg", "https://wowhead.com/item=225891", "")
                },
                {
                    "Holy Priest",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_potiond2.jpg", "https://wowhead.com/item=225891", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/trade_alchemy_potiond2.jpg", "https://wowhead.com/item=225891", "")
                }
            }
        },
        {
            "Viscous Coaglam", new Dictionary<string, TierModel>
            {
                {
                    "Holy Paladin",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_creepingcoagulum_blue.jpg", "https://wowhead.com/item=219320", "")
                },
                {
                    "Restoration Shaman",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_creepingcoagulum_blue.jpg", "https://wowhead.com/item=219320", "An okay trinket that will passively add some healing. There are better options.")
                },
                {
                    "Mistweaver Monk",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_raid_creepingcoagulum_blue.jpg", "https://wowhead.com/item=219320", "")
                }
            }
        },
        {
            "Void Pactstone", new Dictionary<string, TierModel>
            {
                {
                    "Blood Death Knight",
                    new TierModel("B", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=219311", "")
                },
                {
                    "Frost Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=219311", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=219311", "")
                },
                {
                    "Protection Warrior",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=219311", "")
                },
                {
                    "Retribution Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=219311", "Passive damage proc. No special usage required.")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_10_alchemy_alchemystone_color4.jpg", "https://wowhead.com/item=219311", "Another passive trinket that deals reasonable damage and also grants some Haste. Unfortunately, the damage component constitutes too much of its power for it to really stand out.")
                }
            }
        },
        {
            "Void Reaper's Contract", new Dictionary<string, TierModel>
            {
                {
                    "Guardian Druid",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "Deals good passive damage.")
                },
                {
                    "Outlaw Rogue",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "A strong passive trinket that has added synergy with the  Void Reaper's Warp Blade weapon. You don't need this weapon for the trinket to be BIS. It's just an added bonus.")
                },
                {
                    "Windwalker Monk",
                    new TierModel("S", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "A very strong trinket that only gets stronger if you already have the weapon that goes with it, which you should be aiming to get. It is the strongest trinket we can get with an \"Equip\" effect.")
                },
                {
                    "Havoc Demon Hunter",
                    new TierModel("S-", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "A powerful passive trinket that can be used if the BiS options are not available. While  Void Reaper's Contract has a 2-set pairing with  Void Reaper's Warp Blade, it does not push it to be significantly more powerful.")
                },
                {
                    "Vengeance Demon Hunter",
                    new TierModel("A+", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "This has static Agility, and it deals more damage than any other trinket available aside from  Void Reaper's Contract. When you use it, it grants an hour-long buff that allows your attacks to proc a Nature DoT  Flayedwing Toxin with 4+Haste RPPM.")
                },
                {
                    "Assassination Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "One of the best trinkets from the raid but loses to other options")
                },
                {
                    "Beast Mastery Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "")
                },
                {
                    "Brewmaster Monk",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "This trinket's damage is acceptable on its own (despite the 33% damage penalty for being a dps trinket), but when paired with the  Void Reaper's Warp Blade, its full potential is unlocked and brings it to new heights. Consider this among your best options for single-target, and a solid choice for AoE.")
                },
                {
                    "Feral Druid",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "A more passive alternative to Mad Queens Mandate, but still a competitive option. There may be high competition for this trinket as Monks, Demon Hunters, and Rogues have a set bonus combination with it.")
                },
                {
                    "Marksmanship Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "This trinket is one of the strong passive options. There is a set bonus on the item which increases the benefits if you use  Void Reaper's Warp Blade.Don't use the fist weapon under any circumstances, Subtlety Rogue's  Shadow Techniques proc heavily depends on Weapon speed, so using any non-dagger is not recommended.But the trinket is rly good without the weapon.")
                },
                {
                    "Survival Hunter",
                    new TierModel("A", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "Performs very well for Single Target damage, but falls behind drastically for AoE. We cannot make use of the set effect since we cannot utilise the fist weapon that requires it.")
                },
                {
                    "Enhancement Shaman",
                    new TierModel("B+", "https://wow.zamimg.com/images/wow/icons/large/inv_10_inscription2_repcontracts_trade_archaeology_apexisscroll_uprez_color4.jpg", "https://wowhead.com/item=212456", "Flat damage proc that, while it does get stronger if using the rare fist  Void Reaper's Warp Blade, starts out pretty weak because we simply don't stack Crit or Vers to amplify it alongside Haste this early on. Very weighted toward single target too which makes it even more specialized.")
                }
            }
        },
        {
            "Wildfire Wick", new Dictionary<string, TierModel>
            {
                {
                    "Outlaw Rogue",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_red.jpg", "https://wowhead.com/item=218307", "")
                },
                {
                    "Protection Paladin",
                    new TierModel("C", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_red.jpg", "https://wowhead.com/item=218307", "")
                },
                {
                    "Frost Death Knight",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_red.jpg", "https://wowhead.com/item=218307", "")
                },
                {
                    "Subtlety Rogue",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_red.jpg", "https://wowhead.com/item=218307", "")
                },
                {
                    "Unholy Death Knight",
                    new TierModel("D", "https://wow.zamimg.com/images/wow/icons/large/inv_trinket_maldraxxus_01_red.jpg", "https://wowhead.com/item=218307", "")
                }
            }
        }
    };
}