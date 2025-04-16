<script setup lang="ts">
import { ref, onUpdated, onMounted, nextTick, computed } from "vue"
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome"
import { faBroom, faX } from "@fortawesome/free-solid-svg-icons"
import { useRoute } from "vue-router"
import { useSettingsStore } from "@/stores/settingsStore"
import { GroupByMode, useFilterStore } from "@/stores/filterStore"
import TriStateCheckbox from "@/components/TriStateCheckbox.vue"
import data from "@/common/data"

//#region Setup
const settingsStore = useSettingsStore()
const filterStore = useFilterStore()
const route = useRoute()
const filterHovered = ref<"trinket" | "spec" | null>(null)
const allowSpecSorting = ref(true)
const filterDropDown = ref({
  visible: settingsStore.filterOpen,
  sticky: settingsStore.filterOpen,
  timeout: null as number | null
})

onMounted(() => {
  let allowSpecSortingBefore = true
  document.onkeydown = () => {
    if (!filterHovered.value) return

    // Force-allow spec sorting on filter change
    allowSpecSortingBefore = allowSpecSorting.value
    allowSpecSorting.value = true

    // Re-focus input on keyboard event to fix some bugs
    const input = document.getElementById(`${filterHovered.value}-input`)
    input?.blur()
    input?.focus()
  }

  document.onkeyup = () => {
    if (!filterHovered.value) return

    // Restore spec sorting
    allowSpecSorting.value = allowSpecSortingBefore
  }
})
//#endregion

//#region Filter loading/saving logic
// Reset stuff if they are set to not save
if (!settingsStore.saveTrinkets) settingsStore.trinketSearch = ""
if (!settingsStore.saveSpecs) settingsStore.specSearch = ""
if (!settingsStore.saveTrinkets && !settingsStore.saveSpecs) filterStore.groupByMode = GroupByMode.Trinket

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

// Load group by mode
if (route.query.groupByMode) {
  if (route.query.groupByMode === "spec") {
    filterStore.groupByMode = GroupByMode.Spec
  } else {
    filterStore.groupByMode = GroupByMode.Trinket
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
function mouseEvent(target: "trinket" | "spec", action: "enter" | "leave") {
  setFilterVisibility(action === "enter", false)
  filterHovered.value = action === "enter" ? target : null
}

function setFilterVisibility(value: boolean, sticky: boolean) {
  // Do nothing if hovering is disabled
  if (!settingsStore.filterOpenOnHover && !sticky) {
    return
  }

  // Clear running timeout
  if (filterDropDown.value.timeout != null) {
    window.clearTimeout(filterDropDown.value.timeout)
    filterDropDown.value.timeout = null
  }

  // Remove visual text selection
  document.getSelection()?.removeAllRanges()

  if (value) {
    // Do not open if it was sticky closed
    if (!sticky && filterDropDown.value.sticky) {
      return
    }

    filterDropDown.value.visible = true
    filterDropDown.value.sticky = sticky

    if (sticky) {
      settingsStore.filterOpen = true
    }
  } else {
    if (sticky) {
      filterDropDown.value.visible = false
      filterDropDown.value.sticky = true
      settingsStore.filterOpen = false
    } else {
      filterDropDown.value.timeout = window.setTimeout(() => {
        if (filterDropDown.value.visible && !filterDropDown.value.sticky) {
          filterDropDown.value.visible = false
          settingsStore.filterOpen = false
        } else if (!filterDropDown.value.visible) {
          // Remove sticky if hovered out of it and it was closed before
          filterDropDown.value.sticky = false
        }
      }, settingsStore.filterHideDelay)
    }
  }
}

function match(value: string, filter: string) {
  if (filter === "") {
    return true
  }

  if (filter.substring(0, 1) === ":") {
    return new RegExp(filter.substring(1)).test(value)
  }

  const lowerValue = value.toLowerCase()
  const lowerFilter = filter.toLowerCase()

  if (lowerValue.includes(lowerFilter)) {
    return true
  }

  const words = lowerFilter.split(" ")
  for (const word of words) {
    if (!lowerValue.includes(word)) {
      return false
    }
  }

  return true
}

const sortedItems = computed(() => {
  return Object.keys(data.items)
    .filter((key) => filterStore.trinkets.has(key) || match(key, settingsStore.trinketSearch))
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
        sortedItems[key] = data.items[key]
        return sortedItems
      },
      {} as { [itemName: string]: number }
    )
})

const sortedSpecs = computed<
  | {
      [p: string]: string[]
    }
  | undefined
>((previous) => {
  if (!allowSpecSorting.value) return previous

  if (data == null) {
    return {}
  }

  return Object.keys(data.specs)
    .sort((a, b) => {
      const aAny = data.specs[a].some((specName) => filterStore.specs.has(`${specName} ${a}`))
      const bAny = data.specs[b].some((specName) => filterStore.specs.has(`${specName} ${b}`))

      if (aAny && !bAny) {
        return -1
      } else if (!aAny && bAny) {
        return 1
      }

      return a.localeCompare(b, "en")
    })
    .reduce(
      (sortedSpecs, key) => {
        // Apply filter (but always show selected)
        if (
          !data.specs[key].some((specName) => filterStore.specs.has(`${specName} ${key}`) || match(`${specName} ${key}`, settingsStore.specSearch))
        ) {
          return sortedSpecs
        }

        sortedSpecs[key] = data.specs[key]
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
  if (checked == null) {
    let checked = 0
    let total = 0
    for (const spec of data.specs[className]) {
      if (filterStore.specs.has(`${spec} ${className}`)) {
        checked++
      }
      total++
    }
    return checked <= 0 ? 0 : checked === total ? 1 : 2
  }

  for (const spec of data.specs[className]) {
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
  <div class="row" v-bind="$attrs">
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
    <div class="col" @mouseenter="mouseEvent('trinket', 'enter')" @mouseleave="mouseEvent('trinket', 'leave')">
      <div class="clickable" @click="setFilterVisibility(!filterDropDown.visible || !filterDropDown.sticky, true)">
        <div :class="{ 'fw-bold': filterDropDown.visible && filterDropDown.sticky }" data-bs-placement="top" title="Click to open/close filter.">
          Trinket filter
        </div>
      </div>
      <div class="input-group mb-1" :class="{ hidden: !filterDropDown.visible }">
        <input type="text" id="trinket-input" class="form-control" v-model="settingsStore.trinketSearch" />
        <span
          class="input-group-text"
          data-bs-placement="bottom"
          data-bs-html="true"
          title="<div class='mb-1'>Trinket filter search input.</div>
                 <div class='mb-1'>Checked filters are always visible.</div>
                 <div class='mb-1'>Allows partial searches, e.g. <u>ab sp</u> for Aberrant Spellforge, <u>abys</u> for Abyssal Trap.</div>
                 <div class='mb-1'>Also supports regex search, which needs to be prefixed with :, e.g. <u>:^Cirral Concoctory$</u> for exact Cirral Concoctory match.</div>
                 <div class='mb-1'>Case insensitive, except when in regex mode.</div>"
          >?</span
        >
        <button
          type="button"
          class="btn btn-sm btn-with-border btn-outline-danger"
          data-bs-placement="top"
          title="Clear Trinket filter search input."
          @click="settingsStore.trinketSearch = ''"
          :disabled="settingsStore.trinketSearch.length <= 0"
        >
          <FontAwesomeIcon :icon="faX" />
        </button>
      </div>
      <div
        class="filter"
        :style="{
          height: settingsStore.filterHeight > 0 ? `${settingsStore.filterHeight}vh` : '',
          'max-height': settingsStore.filterHeight <= 0 ? '70vh' : ''
        }"
        :class="{ hidden: !filterDropDown.visible }"
      >
        <button
          type="button"
          class="btn btn-sm btn-outline-danger float-end top-0 sticky-top"
          data-bs-toggle="tooltip"
          data-bs-placement="top"
          title="Clear trinket filter."
          :disabled="filterStore.trinkets.size <= 0"
          @click.stop="filterStore.trinkets.clear()"
        >
          <FontAwesomeIcon :icon="faBroom" />
        </button>
        <div class="ms-1 form-check" v-for="(itemId, itemName) in sortedItems" :key="`filter-item-${itemId}`">
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
    <div class="col" @mouseenter="mouseEvent('spec', 'enter')" @mouseleave="mouseEvent('spec', 'leave')">
      <div class="clickable" @click="setFilterVisibility(!filterDropDown.visible || !filterDropDown.sticky, true)">
        <div :class="{ 'fw-bold': filterDropDown.visible && filterDropDown.sticky }" data-bs-placement="top" title="Click to open/close filter.">
          Class / Specialization filter
        </div>
      </div>
      <div class="input-group mb-1" :class="{ hidden: !filterDropDown.visible }">
        <input type="text" id="spec-input" class="form-control" v-model="settingsStore.specSearch" />
        <span
          class="input-group-text"
          data-bs-placement="bottom"
          data-bs-html="true"
          title="<div class='mb-1'>Class / Specialization filter search input.</div>
                 <div class='mb-1'>Checked filters are always visible.</div>
                 <div class='mb-1'>Allows partial searches, e.g. <u>b d k</u> for Blood Death Knight, <u>dev evo</u> for devastation evoker.</div>
                 <div class='mb-1'>Also supports regex search, which needs to be prefixed with :, e.g. <u>:^Fury Warrior$</u> for exact Fury Warrior match.</div>
                 <div>Case insensitive, except when in regex mode.</div>"
          >?</span
        >
        <button
          type="button"
          class="btn btn-sm btn-with-border btn-outline-danger"
          data-bs-placement="top"
          title="Clear Class / Specialization filter search input."
          @click="settingsStore.specSearch = ''"
          :disabled="settingsStore.specSearch.length <= 0"
        >
          <FontAwesomeIcon :icon="faX" />
        </button>
      </div>
      <div
        class="filter"
        :style="{
          height: settingsStore.filterHeight > 0 ? `${settingsStore.filterHeight}vh` : '',
          'max-height': settingsStore.filterHeight <= 0 ? '70vh' : ''
        }"
        :class="{ hidden: !filterDropDown.visible }"
      >
        <button
          type="button"
          class="btn btn-sm btn-outline-danger float-end top-0 sticky-top"
          data-bs-toggle="tooltip"
          data-bs-placement="top"
          title="Clear specialization / class filter."
          :disabled="filterStore.specs.size <= 0"
          @click.stop="filterStore.specs.clear()"
        >
          <FontAwesomeIcon :icon="faBroom" />
        </button>
        <div
          v-for="(specNames, className) in sortedSpecs"
          :key="`filter-class-${className}`"
          @mouseenter="allowSpecSorting = false"
          @mouseleave="allowSpecSorting = true"
        >
          <div class="ms-1 form-check">
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

<style lang="css" scoped>
.filter {
  border: 1px solid #ccc;
  overflow-x: auto;
  overflow-y: scroll;
}
</style>
