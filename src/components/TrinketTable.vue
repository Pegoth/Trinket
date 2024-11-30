<script setup lang="ts">
import { useDataStore } from "@/stores/dataStore"
import { useFilterStore } from "@/stores/filterStore"
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
  const groups: { [key: number]: { spec: string; wowhead: string; bloodmallet: { [key: string]: number }; note: string }[] } = {}

  if (dataStore.data == null) return groups

  // Wowhead
  for (const specName in dataStore.data.wowhead) {
    for (const tierData of dataStore.data.wowhead[specName]) {
      if (groups[tierData.item] == null) {
        groups[tierData.item] = []
      }

      groups[tierData.item].push({
        spec: specName,
        wowhead: tierData.tier,
        bloodmallet: {},
        note: tierData.note
      })
    }
  }

  // Bloodmallet
  for (const specName in dataStore.data.bloodmallet) {
    for (const target in dataStore.data.bloodmallet[specName]) {
      for (const tierData of dataStore.data.bloodmallet[specName][target]) {
        if (groups[tierData.item] == null) {
          groups[tierData.item] = []
        }

        const row = groups[tierData.item].find((row) => row.spec === specName)
        if (row == null) {
          groups[tierData.item].push({
            spec: specName,
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

  return groups
})
</script>

<template>
  <table>
    <thead>
      <tr>
        <th rowspan="2">Spec / class</th>
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
      <template v-for="(rows, itemId) in rowGroups">
        <tr>
          <td colspan="6">
            <a
              :href="`https://wowhead.com/item=${itemId}?ilvl=${settingsStore.itemLevel}&lvl=${settingsStore.level}`"
              data-wh-icon-size="medium"
              target="_blank"
            ></a>
          </td>
        </tr>
        <tr v-for="row in rows">
          <td>{{ row.spec }}</td>
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
