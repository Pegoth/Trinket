<script setup lang="ts">
import { useDataStore } from "@/stores/dataStore"
import { GroupByMode, useFilterStore } from "@/stores/filterStore"
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

const rowGroups = computed(() => {
  const groups: { [groupKey: string]: { specOrItem: string; wowhead: string; bloodmallet: { [targets: string]: number }; note: string }[] } = {}

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
      break
    }
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
</script>

<template>
  <table>
    <thead>
      <tr>
        <th rowspan="2">{{ firstColumnText }}</th>
        <th rowspan="2">Wowhead</th>
        <th colspan="3">Bloodmallet</th>
        <th rowspan="2">Note</th>
      </tr>
      <tr>
        <th>1</th>
        <th>3</th>
        <th>5</th>
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
