<script setup lang="ts">
import { ref, onUpdated, onMounted, nextTick, computed } from "vue"
import { useRoute } from "vue-router"
import { useSettingsStore } from "@/stores/settingsStore"
import { GroupByMode, useFilterStore } from "@/stores/filterStore"
import { useDataStore } from "@/stores/dataStore"
import TriStateCheckbox from "@/components/TriStateCheckbox.vue"

//#region Setup
const settingsStore = useSettingsStore()
const dataStore = useDataStore()
const filterStore = useFilterStore()
const route = useRoute()
const filterDropDown = ref({
  visible: false,
  timeout: null as number | null
})

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
const refreshLinks = () => {
  if (window.$WowheadPower != null && typeof window.$WowheadPower.refreshLinks == "function") {
    window.$WowheadPower.refreshLinks()
  }
}

onUpdated(refreshLinks)
onMounted(refreshLinks)
//#endregion

//#region Helpers
function setFilterVisibility(visible: boolean) {
  if (visible) {
    if (filterDropDown.value.timeout != null) {
      clearTimeout(filterDropDown.value.timeout)
    }

    filterDropDown.value.timeout = null
    filterDropDown.value.visible = true
  } else {
    filterDropDown.value.timeout = window.setTimeout(() => {
      filterDropDown.value.visible = false
    }, settingsStore.filterHideDelay)
  }
}

const sortedItems = computed(() => {
  if (dataStore.data == null) {
    return {}
  }

  return Object.keys(dataStore.data.items)
    .sort((a, b) => {
      const aChecked = filterStore.trinkets.has(a)
      const bChecked = filterStore.trinkets.has(b)

      if (aChecked && !bChecked) {
        return -1
      } else if (!aChecked && bChecked) {
        return 1
      }

      return a.localeCompare(b, "en")
    })
    .reduce(
      (sortedItems, key) => {
        if (dataStore.data == null) {
          return sortedItems
        }

        sortedItems[key] = dataStore.data.items[key]
        return sortedItems
      },
      {} as { [itemName: string]: number }
    )
})

const sortedSpecs = computed(() => {
  if (dataStore.data == null) {
    return {}
  }

  return Object.keys(dataStore.data.specs)
    .sort((a, b) => {
      if (dataStore.data == null) {
        return 0
      }

      const aAny = dataStore.data.specs[a].some((specName) => filterStore.specs.has(`${specName} ${a}`))
      const bAny = dataStore.data.specs[b].some((specName) => filterStore.specs.has(`${specName} ${b}`))

      if (aAny && !bAny) {
        return -1
      } else if (!aAny && bAny) {
        return 1
      }

      return a.localeCompare(b, "en")
    })
    .reduce(
      (sortedSpecs, key) => {
        if (dataStore.data == null) {
          return sortedSpecs
        }

        sortedSpecs[key] = dataStore.data.specs[key]
        return sortedSpecs
      },
      {} as { [className: string]: string[] }
    )
})

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

function classChecked(className: string, checked?: boolean | null) {
  if (dataStore.data == null) {
    return 0
  }

  if (checked == null) {
    let checked = 0
    let total = 0
    for (const spec of dataStore.data.specs[className]) {
      if (filterStore.specs.has(`${spec} ${className}`)) {
        checked++
      }
      total++
    }
    return checked <= 0 ? 0 : checked === total ? 1 : 2
  }

  for (const spec of dataStore.data.specs[className]) {
    const value = `${spec} ${className}`
    if (checked) {
      filterStore.specs.add(value)
    } else {
      filterStore.specs.delete(value)
    }
  }

  return checked ? 1 : 0
}

function specChecked(className: string, specName: string, checked?: boolean | null) {
  const key = `${specName} ${className}`
  if (checked == null) {
    return filterStore.specs.has(key)
  }

  if (checked) {
    filterStore.specs.add(key)
  } else {
    filterStore.specs.delete(key)
  }

  return checked
}
//#endregion
</script>

<template>
  <template v-if="dataStore.data != null">
    <div class="row">
      <div class="col-3 form-check form-switch">
        <input
          type="checkbox"
          id="group_by_mode"
          class="form-check-input"
          :checked="groupByMode()"
          @change="nextTick(() => groupByMode(($event.target as HTMLInputElement)?.checked))"
        />
        <label for="group_by_mode" class="form-check-label">Group by {{ groupByMode() ? "specialization / class" : "trinket" }}</label>
      </div>
      <div class="col" @mouseenter="setFilterVisibility(true)" @mouseleave="setFilterVisibility(false)">
        <label>Trinket filter</label>
        <div class="overflow-auto" style="max-height: 70vh" :style="{ display: filterDropDown.visible ? 'block' : 'none' }">
          <div class="form-check" v-for="(itemId, itemName) in sortedItems" :key="`filter-item-${itemId}`">
            <input
              type="checkbox"
              class="form-check-input"
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
      </div>
      <div class="col" @mouseenter="setFilterVisibility(true)" @mouseleave="setFilterVisibility(false)">
        <label>Class / Specialization filter</label>
        <div class="overflow-auto" style="max-height: 70vh" :style="{ display: filterDropDown.visible ? 'block' : 'none' }">
          <div v-for="(specNames, className) in sortedSpecs" :key="`filter-class-${className}`">
            <div class="form-check">
              <TriStateCheckbox
                class="form-check-input"
                :id="className.toString()"
                :value="classChecked(className.toString())"
                @change="nextTick(() => classChecked(className.toString(), ($event.target as HTMLInputElement)?.checked))"
              />
              <label class="form-check-label" :for="className.toString()">{{ className }}</label>
            </div>
            <div class="form-check ms-4" v-for="specName in specNames" :key="`filter-spec-${className}-${specName}`">
              <input
                type="checkbox"
                class="form-check-input"
                :id="`${specName} ${className}`"
                :checked="specChecked(className.toString(), specName)"
                @change="nextTick(() => specChecked(className.toString(), specName, ($event.target as HTMLInputElement)?.checked))"
              />
              <label class="form-check-label" :for="`${specName} ${className}`">{{ specName }}</label>
            </div>
          </div>
        </div>
      </div>
    </div>
  </template>
  <div v-else>
    {{ init }}
  </div>
</template>
