<script setup lang="ts">
import { useDataStore } from "@/stores/dataStore"
import { GroupByMode, OrderByColumn, OrderByDirection, useFilterStore } from "@/stores/filterStore"
import { useSettingsStore } from "@/stores/settingsStore"
import { onUpdated, onMounted, computed } from "vue"

//#region Setup
const dataStore = useDataStore()
const filterStore = useFilterStore()
const settingsStore = useSettingsStore()

// Load data
const init = await dataStore.init()
if (init) console.error(init)
//#endregion

//#region Wowhead link generation
declare global {
  interface Window {
    $WowheadPower: any
  }
}

const refreshLinks = () => {
  if (window.$WowheadPower != null && typeof window.$WowheadPower.refreshLinks == "function") {
    window.$WowheadPower.refreshLinks()
  }
}

onUpdated(refreshLinks)
onMounted(refreshLinks)
//#endregion

function getNumTier(tier: string) {
  if (tier == null) {
    return 99
  }

  tier = tier.trim().toLowerCase()
  if (tier == "") {
    return 99
  }

  // Get the base value
  let value = 99
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
  let groups: { [groupKey: string]: { specOrItem: string; wowhead: string; bloodmallet: { [targets: string]: number }; note: string }[] } = {}

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
                wowhead: "",
                bloodmallet: {
                  [target]: tierData.tier
                },
                note: ""
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
          {} as { [groupKey: string]: { specOrItem: string; wowhead: string; bloodmallet: { [targets: string]: number }; note: string }[] }
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
                wowhead: "",
                bloodmallet: {
                  [target]: tierData.tier
                },
                note: ""
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
          {} as { [groupKey: string]: { specOrItem: string; wowhead: string; bloodmallet: { [targets: string]: number }; note: string }[] }
        )
      break
    }
  }

  // Sort rows
  for (const groupKey in groups) {
    groups[groupKey].sort((a, b) => {
      // Get sorting directions
      const sortByItemOrSpec = filterStore.getDirection(OrderByColumn.ItemOrSpec)
      const sortByWowhead = filterStore.getDirection(OrderByColumn.Wowhead)
      const sortByBloodmallet1 = filterStore.getDirection(OrderByColumn.Bloodmallet1)
      const sortByBloodmallet3 = filterStore.getDirection(OrderByColumn.Bloodmallet3)
      const sortByBloodmallet5 = filterStore.getDirection(OrderByColumn.Bloodmallet5)

      // Sort by columns
      let q = 0,
        w = 0,
        e = 0,
        r = 0,
        t = 0

      if (sortByItemOrSpec != null) {
        switch (sortByItemOrSpec.direction) {
          case OrderByDirection.Asc:
            q = a.specOrItem.localeCompare(b.specOrItem, "en")
            break
          case OrderByDirection.Desc:
            q = b.specOrItem.localeCompare(a.specOrItem, "en")
            break
        }
      }
      if (sortByWowhead != null) {
        switch (sortByWowhead.direction) {
          case OrderByDirection.Asc:
            w = getNumTier(a.wowhead) - getNumTier(b.wowhead)
            break
          case OrderByDirection.Desc:
            w = getNumTier(b.wowhead) - getNumTier(a.wowhead)
            break
        }
      }
      if (sortByBloodmallet1 != null) {
        switch (sortByBloodmallet1.direction) {
          case OrderByDirection.Asc:
            e = a.bloodmallet["1"] - b.bloodmallet["1"]
            break
          case OrderByDirection.Desc:
            e = b.bloodmallet["1"] - a.bloodmallet["1"]
            break
        }
      }
      if (sortByBloodmallet3 != null) {
        switch (sortByBloodmallet3.direction) {
          case OrderByDirection.Asc:
            r = a.bloodmallet["3"] - b.bloodmallet["3"]
            break
          case OrderByDirection.Desc:
            r = b.bloodmallet["3"] - a.bloodmallet["3"]
            break
        }
      }
      if (sortByBloodmallet5 != null) {
        switch (sortByBloodmallet5.direction) {
          case OrderByDirection.Asc:
            t = a.bloodmallet["5"] - b.bloodmallet["5"]
            break
          case OrderByDirection.Desc:
            t = b.bloodmallet["5"] - a.bloodmallet["5"]
            break
        }
      }

      return q || w || e || r || t
    })
  }

  return groups
})

const firstColumnText = computed(() => {
  switch (filterStore.groupByMode) {
    case GroupByMode.Trinket:
      return "Spec / class"
    case GroupByMode.Spec:
      return "Trinket"
  }
})

function getOrderByIcon(column: OrderByColumn) {
  const order = filterStore.getDirection(column)
  if (order == null) return ""
  return `${order.direction === OrderByDirection.Asc ? "↓" : "↑"}${order.index ?? ""}`
}
</script>

<template>
  <table>
    <thead>
      <tr>
        <th rowspan="2" @click="filterStore.toggleOrderBy(OrderByColumn.ItemOrSpec, !$event.ctrlKey && !$event.altKey && !$event.shiftKey)">
          {{ firstColumnText }} {{ getOrderByIcon(OrderByColumn.ItemOrSpec) }}
        </th>
        <th rowspan="2" @click="filterStore.toggleOrderBy(OrderByColumn.Wowhead, !$event.ctrlKey && !$event.altKey && !$event.shiftKey)">
          Wowhead {{ getOrderByIcon(OrderByColumn.Wowhead) }}
        </th>
        <th colspan="3">Bloodmallet</th>
        <th rowspan="2">Note</th>
      </tr>
      <tr>
        <th @click="filterStore.toggleOrderBy(OrderByColumn.Bloodmallet1, !$event.ctrlKey && !$event.altKey && !$event.shiftKey)">
          1 {{ getOrderByIcon(OrderByColumn.Bloodmallet1) }}
        </th>
        <th @click="filterStore.toggleOrderBy(OrderByColumn.Bloodmallet3, !$event.ctrlKey && !$event.altKey && !$event.shiftKey)">
          3 {{ getOrderByIcon(OrderByColumn.Bloodmallet3) }}
        </th>
        <th @click="filterStore.toggleOrderBy(OrderByColumn.Bloodmallet5, !$event.ctrlKey && !$event.altKey && !$event.shiftKey)">
          5 {{ getOrderByIcon(OrderByColumn.Bloodmallet5) }}
        </th>
      </tr>
    </thead>
    <tbody>
      <template v-for="(rows, groupKey) in rowGroups">
        <tr v-if="filterStore.groupByMode == GroupByMode.Trinket">
          <td colspan="6">
            <a
              :href="`https://wowhead.com/item=${dataStore.data?.items[groupKey]}?ilvl=${settingsStore.itemLevel}&lvl=${settingsStore.level}`"
              data-wh-icon-size="medium"
              target="_blank"
              >{{ groupKey }}</a
            >
          </td>
        </tr>
        <tr v-else-if="filterStore.groupByMode == GroupByMode.Spec">
          <td colspan="6">
            {{ groupKey }}
          </td>
        </tr>
        <tr v-for="row in rows">
          <td v-if="filterStore.groupByMode == GroupByMode.Trinket">{{ row.specOrItem }}</td>
          <td v-else-if="filterStore.groupByMode == GroupByMode.Spec">
            <a
              :href="`https://wowhead.com/item=${dataStore.data?.items[row.specOrItem]}?ilvl=${settingsStore.itemLevel}&lvl=${settingsStore.level}`"
              data-wh-icon-size="medium"
              target="_blank"
              >{{ row.specOrItem }}</a
            >
          </td>
          <td>{{ row.wowhead }}</td>
          <td>{{ row.bloodmallet["1"] }}</td>
          <td>{{ row.bloodmallet["3"] }}</td>
          <td>{{ row.bloodmallet["5"] }}</td>
          <td>{{ row.note }}</td>
        </tr>
      </template>
    </tbody>
  </table>
</template>
