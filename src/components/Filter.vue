<script setup lang="ts">
import { useSettingsStore } from "@/stores/settingsStore"
import { GroupByMode, useFilterStore } from "@/stores/filterStore"
import { useDataStore } from "@/stores/dataStore"
import { useRoute } from "vue-router"
import { onUpdated, onMounted, nextTick } from "vue"

//#region Setup
const settingsStore = useSettingsStore()
const dataStore = useDataStore()
const filterStore = useFilterStore()
const route = useRoute()

// Load data
const init = await dataStore.init()
if (init) console.error(init)
//#endregion

//#region Filter loading/saving logic
// Load trinket filters
filterStore.trinkets.clear()
if (route.query.trinkets) {
  if (typeof route.query.trinkets === "string") {
    for (const trinket of route.query.trinkets.split(",")) {
      filterStore.trinkets.add(trinket)
    }
  } else {
    for (const trinket of route.query.trinkets) {
      if (trinket != null) {
        filterStore.trinkets.add(trinket)
      }
    }
  }
} else {
  for (const trinket of settingsStore.trinkets) {
    filterStore.trinkets.add(trinket)
  }
}

// Load spec filters
filterStore.specs.clear()
if (route.query.specs) {
  if (typeof route.query.specs === "string") {
    for (const spec of route.query.specs.split(",")) {
      filterStore.specs.add(spec)
    }
  } else {
    for (const spec of route.query.specs) {
      if (spec != null) {
        filterStore.specs.add(spec)
      }
    }
  }
} else {
  for (const spec of settingsStore.specs) {
    filterStore.specs.add(spec)
  }
}

filterStore.$subscribe(() => {
  // Save filters to settings store or clear them if they are not empty
  if (settingsStore.saveTrinkets) {
    settingsStore.trinkets = [...filterStore.trinkets]
  } else if (settingsStore.trinkets.length > 0) {
    settingsStore.trinkets = []
  }

  if (settingsStore.saveSpecs) {
    settingsStore.specs = [...filterStore.specs]
  } else if (settingsStore.specs.length > 0) {
    settingsStore.specs = []
  }
})
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

//#region Helpers
function groupByMode(checked?: boolean | null) {
  if (checked == null) {
    return filterStore.groupByMode === GroupByMode.Spec
  }
  if (checked) {
    filterStore.groupByMode = GroupByMode.Spec
  } else {
    filterStore.groupByMode = GroupByMode.Trinket
  }
  return checked
}

function itemChecked(item: string, checked: boolean | null) {
  if (checked) {
    filterStore.trinkets.add(item)
  } else {
    filterStore.trinkets.delete(item)
  }
}

function classChecked(className: string, checked: boolean | null) {
  if (dataStore.data == null) return

  for (const spec of dataStore.data.specs[className]) {
    const value = `${spec} ${className}`
    if (checked) {
      filterStore.specs.add(value)
    } else {
      filterStore.specs.delete(value)
    }
  }
}

function specChecked(spec: string, checked: boolean | null) {
  if (checked) {
    filterStore.specs.add(spec)
  } else {
    filterStore.specs.delete(spec)
  }
}
//#endregion
</script>

<template>
  <template v-if="dataStore.data != null">
    <div>
      <input
        type="checkbox"
        id="group_by_mode"
        :checked="groupByMode()"
        @change="nextTick(() => groupByMode(($event.target as HTMLInputElement)?.checked))"
      />
      <label for="group_by_mode">Group by {{ groupByMode() ? "specialization / class" : "trinket" }}</label>
    </div>
    <div>
      <label>Trinkets</label>
      <div v-for="(itemId, itemName) in dataStore.data.items">
        <input
          type="checkbox"
          :checked="filterStore.trinkets.has(itemName.toString())"
          @change="nextTick(() => itemChecked(itemName.toString(), ($event.target as HTMLInputElement)?.checked))"
        />
        <a
          :href="`https://wowhead.com/item=${itemId}?ilvl=${settingsStore.itemLevel}&lvl=${settingsStore.level}`"
          data-wh-icon-size="small"
          target="_blank"
          @click.prevent="itemChecked(itemName.toString(), !filterStore.trinkets.has(itemName.toString()))"
          >{{ itemName }}</a
        >
      </div>
    </div>
    <div>
      <label>Classes / Specializations</label>
      <div v-for="(specNames, className) in dataStore.data.specs">
        <div>
          <input
            type="checkbox"
            :id="className.toString()"
            :checked="dataStore.data.specs[className].every((specName) => filterStore.specs.has(`${specName} ${className}`))"
            @change="nextTick(() => classChecked(className.toString(), ($event.target as HTMLInputElement)?.checked))"
          />
          <label :for="className.toString()">{{ className }}</label>
        </div>
        <div v-for="specName in specNames">
          <input
            type="checkbox"
            :id="`${specName} ${className}`"
            :checked="filterStore.specs.has(`${specName} ${className}`)"
            @change="nextTick(() => specChecked(`${specName} ${className}`, ($event.target as HTMLInputElement)?.checked))"
          />
          <label :for="`${specName} ${className}`">{{ specName }}</label>
        </div>
      </div>
    </div>
  </template>
  <div v-else>
    {{ init }}
  </div>
</template>
