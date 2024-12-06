<!-- eslint-disable vue/multi-word-component-names -->
<script setup lang="ts">
import { onMounted } from "vue"
import { useSettingsStore } from "@/stores/settingsStore"
import { Tooltip, Modal } from "bootstrap"

const settingsStore = useSettingsStore()

settingsStore.$subscribe(() => {
  if (!settingsStore.saveTrinkets && settingsStore.trinkets.length > 0) {
    Modal.getOrCreateInstance("#clear-trinkets-modal").show()
  }

  if (!settingsStore.saveSpecs && settingsStore.specs.length > 0) {
    Modal.getOrCreateInstance("#clear-specs-modal").show()
  }

  if (settingsStore.filterHideDelay < 0) {
    settingsStore.filterHideDelay = 0
  }
})

// Turn on tooltips
onMounted(() => {
  document.querySelectorAll('[data-bs-toggle="tooltip"]').forEach((tooltip) => {
    new Tooltip(tooltip)
  })
})
</script>

<template>
  <div id="clear-trinkets-modal" class="modal" tabindex="-1">
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Clearing saved trinkets filter</h5>
          <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" @click="settingsStore.saveTrinkets = true"></button>
        </div>
        <div class="modal-body">
          <p>Disabling this option will clear the currently saved trinket filter, are you sure?</p>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-secondary" data-bs-dismiss="modal" @click="settingsStore.saveTrinkets = true">No, keep it</button>
          <button type="button" class="btn btn-danger" data-bs-dismiss="modal" @click="settingsStore.trinkets = []">Yes, clear it</button>
        </div>
      </div>
    </div>
  </div>
  <div id="clear-specs-modal" class="modal" tabindex="-1">
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Clearing saved specialization filter</h5>
          <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" @click="settingsStore.saveSpecs = true"></button>
        </div>
        <div class="modal-body">
          <p>Disabling this option will clear the currently saved specialization / class filter, are you sure?</p>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-secondary" data-bs-dismiss="modal" @click="settingsStore.saveSpecs = true">No, keep it</button>
          <button type="button" class="btn btn-danger" data-bs-dismiss="modal" @click="settingsStore.specs = []">Yes, clear it</button>
        </div>
      </div>
    </div>
  </div>
  <main class="container">
    <h1>Settings</h1>
    <div class="mb-2">
      <label for="item-level" class="form-label">Item Level</label>
      <input
        type="number"
        id="item-level"
        class="form-control"
        data-bs-toggle="tooltip"
        data-bs-placement="top"
        title="The item level for the trinket tooltips."
        v-model="settingsStore.itemLevel"
      />
    </div>
    <div class="mb-2">
      <label for="level" class="form-label">Level</label>
      <input
        type="number"
        id="level"
        class="form-control"
        data-bs-toggle="tooltip"
        data-bs-placement="top"
        title="The character level for the trinket tooltips."
        v-model="settingsStore.level"
      />
    </div>
    <div class="mb-2 form-check">
      <input type="checkbox" id="filter-open-on-hover" class="form-check-input" v-model="settingsStore.filterOpenOnHover" />
      <label
        for="filter-open-on-hover"
        class="form-check-label"
        data-bs-toggle="tooltip"
        data-bs-placement="right"
        data-bs-html="true"
        title="Open the filter dropdown when hovering the labels.<br/>This will also automatically hide it if the mouse leaves the dropdown."
        >Open filters on hovering the labels</label
      >
    </div>
    <div class="mb-2" :class="{ hidden: !settingsStore.filterOpenOnHover }">
      <label for="level" class="form-label">Filter hide delay</label>
      <input
        type="number"
        id="level"
        class="form-control"
        data-bs-toggle="tooltip"
        data-bs-placement="top"
        data-bs-html="true"
        title="The delay before hiding the filter dropdown when the mouse leaves it.<br/>Value is in milliseconds.<br/>Set to 0 to immediately hide the dropdown."
        v-model="settingsStore.filterHideDelay"
      />
    </div>
    <div class="mb-2 form-check">
      <input type="checkbox" id="save-trinkets" class="form-check-input" v-model="settingsStore.saveTrinkets" />
      <label
        for="save-trinkets"
        class="form-check-label"
        data-bs-toggle="tooltip"
        data-bs-placement="right"
        data-bs-html="true"
        title="Save the selected trinket filters to local storage to keep it for the next time the page opens.<br/>URLs with filters will overwrite this setting and show them instead, BUT they are not saved until modified."
        >Save selected trinkets</label
      >
    </div>
    <div class="form-check">
      <input type="checkbox" id="save-specs" class="form-check-input" v-model="settingsStore.saveSpecs" />
      <label
        for="save-specs"
        class="form-check-label"
        data-bs-toggle="tooltip"
        data-bs-placement="right"
        data-bs-html="true"
        title="Save the selected specializations filters to local storage to keep it for the next time the page opens.<br/>URLs with filters will overwrite this setting and show them instead, BUT they are not saved until modified."
        >Save selected specializations</label
      >
    </div>
  </main>
</template>
