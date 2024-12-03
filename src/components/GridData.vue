<script setup lang="ts">
import { useDataStore } from "@/stores/dataStore"
import { GroupByMode, OrderByColumn, OrderByDirection, useFilterStore } from "@/stores/filterStore"
import { useSettingsStore } from "@/stores/settingsStore"
import GridSortableColumn from "./GridSortableColumn.vue"
import { onUpdated, onMounted, computed } from "vue"

//#region Setup
const undefinedSortValue = 9999
const dataStore = useDataStore()
const filterStore = useFilterStore()
const settingsStore = useSettingsStore()

// Load data
const init = await dataStore.init()
if (init) console.error(init)
//#endregion

//#region Wowhead link generation
const refreshLinks = () => {
  if (window.$WowheadPower != null && typeof window.$WowheadPower.refreshLinks == "function") {
    window.$WowheadPower.refreshLinks()
  }
}

onUpdated(refreshLinks)
onMounted(refreshLinks)
//#endregion

function getNumTier(tier: string | undefined) {
  if (tier == null) {
    return undefinedSortValue
  }

  tier = tier.trim().toLowerCase()
  if (tier == "") {
    return undefinedSortValue
  }

  // Get the base value
  let value = undefinedSortValue
  switch (tier.substring(0, 1)) {
    case "s":
      value = 1
      break
    case "a":
      value = 4
      break
    case "b":
      value = 7
      break
    case "c":
      value = 10
      break
    case "d":
      value = 13
      break
    case "e":
      value = 16
      break
    case "f":
      value = 19
      break
  }

  // Check if it is possible to have a modifier or not
  if (tier.length <= 1) {
    return value
  }

  // Change based on modifier
  switch (tier.substring(1, 2)) {
    case "-":
      value++
      break
    case "+":
      value--
      break
  }

  return value
}

const rowGroups = computed(() => {
  let groups: { [groupKey: string]: { specOrItem: string; wowhead?: string; bloodmallet: { [targets: string]: number }; note?: string }[] } = {}

  if (dataStore.data == null) {
    return groups
  }

  switch (filterStore.groupByMode) {
    case GroupByMode.Trinket: {
      // Wowhead
      for (const specName in dataStore.data.wowhead) {
        if (filterStore.specs.size > 0 && !filterStore.specs.has(specName)) {
          continue
        }

        for (const tierData of dataStore.data.wowhead[specName]) {
          if (filterStore.trinkets.size > 0 && !filterStore.trinkets.has(tierData.item)) {
            continue
          }

          if (groups[tierData.item] == null) {
            groups[tierData.item] = []
          }

          groups[tierData.item].push({
            specOrItem: specName,
            wowhead: tierData.tier,
            bloodmallet: {},
            note: tierData.note
          })
        }
      }

      // Bloodmallet
      for (const specName in dataStore.data.bloodmallet) {
        if (filterStore.specs.size > 0 && !filterStore.specs.has(specName)) {
          continue
        }

        for (const target in dataStore.data.bloodmallet[specName]) {
          for (const tierData of dataStore.data.bloodmallet[specName][target]) {
            if (filterStore.trinkets.size > 0 && !filterStore.trinkets.has(tierData.item)) {
              continue
            }

            if (groups[tierData.item] == null) {
              groups[tierData.item] = []
            }

            const row = groups[tierData.item].find((row) => row.specOrItem === specName)
            if (row == null) {
              groups[tierData.item].push({
                specOrItem: specName,
                bloodmallet: {
                  [target]: tierData.tier
                }
              })
            } else {
              row.bloodmallet[target] = tierData.tier
            }
          }
        }
      }

      // Sort groupKeys
      groups = Object.keys(groups)
        .sort()
        .reduce(
          (sortedGroups, key) => {
            sortedGroups[key] = groups[key]
            return sortedGroups
          },
          {} as { [groupKey: string]: { specOrItem: string; wowhead?: string; bloodmallet: { [targets: string]: number }; note?: string }[] }
        )
      break
    }
    case GroupByMode.Spec: {
      // Wowhead
      for (const specName in dataStore.data.wowhead) {
        if (filterStore.specs.size > 0 && !filterStore.specs.has(specName)) {
          continue
        }

        if (groups[specName] == null) {
          groups[specName] = []
        }

        for (const tierData of dataStore.data.wowhead[specName]) {
          if (filterStore.trinkets.size > 0 && !filterStore.trinkets.has(tierData.item)) {
            continue
          }

          groups[specName].push({
            specOrItem: tierData.item,
            wowhead: tierData.tier,
            bloodmallet: {},
            note: tierData.note
          })
        }
      }

      // Bloodmallet
      for (const specName in dataStore.data.bloodmallet) {
        if (filterStore.specs.size > 0 && !filterStore.specs.has(specName)) {
          continue
        }

        if (groups[specName] == null) {
          groups[specName] = []
        }

        for (const target in dataStore.data.bloodmallet[specName]) {
          for (const tierData of dataStore.data.bloodmallet[specName][target]) {
            if (filterStore.trinkets.size > 0 && !filterStore.trinkets.has(tierData.item)) {
              continue
            }

            const row = groups[specName].find((row) => row.specOrItem === tierData.item)
            if (row == null) {
              groups[specName].push({
                specOrItem: tierData.item,
                bloodmallet: {
                  [target]: tierData.tier
                }
              })
            } else {
              row.bloodmallet[target] = tierData.tier
            }
          }
        }
      }

      // Cleanup
      for (const groupKey in groups) {
        if (groups[groupKey].length === 0) {
          delete groups[groupKey]
        }
      }

      // Sort groupKeys
      groups = Object.keys(groups)
        .sort((a, b) => {
          if (dataStore.data == null) {
            return 0
          }

          const aClass = dataStore.findClassForSpec(a) ?? ""
          const bClass = dataStore.findClassForSpec(b) ?? ""
          return aClass.localeCompare(bClass, "en") || a.localeCompare(b, "en")
        })
        .reduce(
          (sortedGroups, key) => {
            sortedGroups[key] = groups[key]
            return sortedGroups
          },
          {} as { [groupKey: string]: { specOrItem: string; wowhead?: string; bloodmallet: { [targets: string]: number }; note?: string }[] }
        )
      break
    }
  }

  // Sort rows
  for (const groupKey in groups) {
    groups[groupKey].sort((a, b) => {
      // Compare in order of orderBys set up by the user
      for (const orderBy of filterStore.orderBy) {
        let compare = 0
        switch (orderBy.column) {
          case OrderByColumn.ItemOrSpec:
            compare =
              orderBy.direction === OrderByDirection.Asc
                ? a.specOrItem.localeCompare(b.specOrItem, "en")
                : b.specOrItem.localeCompare(a.specOrItem, "en")
            break
          case OrderByColumn.Wowhead:
            compare =
              orderBy.direction === OrderByDirection.Asc
                ? getNumTier(a.wowhead) - getNumTier(b.wowhead)
                : getNumTier(b.wowhead) - getNumTier(a.wowhead)
            break
          case OrderByColumn.Bloodmallet1:
            compare =
              orderBy.direction === OrderByDirection.Asc
                ? (a.bloodmallet["1"] ?? undefinedSortValue) - (b.bloodmallet["1"] ?? undefinedSortValue)
                : (b.bloodmallet["1"] ?? undefinedSortValue) - (a.bloodmallet["1"] ?? undefinedSortValue)
            break
          case OrderByColumn.Bloodmallet3:
            compare =
              orderBy.direction === OrderByDirection.Asc
                ? (a.bloodmallet["3"] ?? undefinedSortValue) - (b.bloodmallet["3"] ?? undefinedSortValue)
                : (b.bloodmallet["3"] ?? undefinedSortValue) - (a.bloodmallet["3"] ?? undefinedSortValue)
            break
          case OrderByColumn.Bloodmallet5:
            compare =
              orderBy.direction === OrderByDirection.Asc
                ? (a.bloodmallet["5"] ?? undefinedSortValue) - (b.bloodmallet["5"] ?? undefinedSortValue)
                : (b.bloodmallet["5"] ?? undefinedSortValue) - (a.bloodmallet["5"] ?? undefinedSortValue)
            break
        }

        if (!isNaN(compare) && compare != null && compare !== 0) {
          return compare
        }
      }

      return 0
    })
  }

  return groups
})
</script>

<template>
  <div class="mt-2 table-responsive">
    <table class="table table-hover table-borderless">
      <thead>
        <tr>
          <GridSortableColumn :column="OrderByColumn.ItemOrSpec" class="pt-0 text-center" />
          <GridSortableColumn :column="OrderByColumn.Wowhead" class="pt-0 text-center" />
          <th colspan="3" class="auto-size p-0 text-center">Bloodmallet</th>
          <th rowspan="2" class="pt-0 text-center">Note</th>
        </tr>
        <tr>
          <GridSortableColumn :column="OrderByColumn.Bloodmallet1" class="pt-0 text-center" />
          <GridSortableColumn :column="OrderByColumn.Bloodmallet3" class="pt-0 text-center" />
          <GridSortableColumn :column="OrderByColumn.Bloodmallet5" class="pt-0 text-center" />
        </tr>
      </thead>
      <tbody>
        <template v-for="(rows, groupKey) in rowGroups">
          <tr v-if="filterStore.groupByMode == GroupByMode.Trinket" :key="`grid-trinket-${groupKey}`">
            <td colspan="6" class="text-nowrap fs-4">
              <a
                :href="`https://wowhead.com/item=${dataStore.data?.items[groupKey]}?ilvl=${settingsStore.itemLevel}&lvl=${settingsStore.level}`"
                data-wh-icon-size="medium"
                target="_blank"
                >{{ groupKey }}</a
              >
            </td>
          </tr>
          <tr v-else-if="filterStore.groupByMode == GroupByMode.Spec" :key="`grid-spec-${groupKey}`">
            <td colspan="6" class="text-nowrap fs-4">
              {{ groupKey }}
            </td>
          </tr>
          <tr v-for="(row, i) in rows" :class="{ 'border-top': i > 0 }" :key="`grid-row-${row.specOrItem}`">
            <td class="text-nowrap align-middle" v-if="filterStore.groupByMode == GroupByMode.Trinket">
              {{ row.specOrItem }}
            </td>
            <td class="text-nowrap align-middle" v-else-if="filterStore.groupByMode == GroupByMode.Spec">
              <a
                :href="`https://wowhead.com/item=${dataStore.data?.items[row.specOrItem]}?ilvl=${settingsStore.itemLevel}&lvl=${settingsStore.level}`"
                data-wh-icon-size="medium"
                target="_blank"
                >{{ row.specOrItem }}</a
              >
            </td>
            <td class="text-nowrap text-center align-middle">{{ row.wowhead ?? "?" }}</td>
            <td class="text-nowrap text-center align-middle">{{ row.bloodmallet["1"] ?? "?" }}</td>
            <td class="text-nowrap text-center align-middle">{{ row.bloodmallet["3"] ?? "?" }}</td>
            <td class="text-nowrap text-center align-middle">{{ row.bloodmallet["5"] ?? "?" }}</td>
            <td class="align-middle">{{ row.note }}</td>
          </tr>
        </template>
      </tbody>
    </table>
  </div>
</template>
