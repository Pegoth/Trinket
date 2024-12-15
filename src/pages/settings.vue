<!-- eslint-disable vue/multi-word-component-names -->
<script setup lang="ts">
import { Modal } from "bootstrap"
import { useSettingsStore } from "@/stores/settingsStore"
import SettingsInput from "@/components/SettingsInput.vue"

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

  if (settingsStore.filterHeight < 0 || settingsStore.filterHeight > 100) {
    settingsStore.filterHeight = Math.min(100, Math.max(0, settingsStore.filterHeight))
  }
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
    <SettingsInput class="mb-2" label="Item Level" tooltip="The item level for the trinket tooltips." :min="0" v-model="settingsStore.itemLevel" />
    <SettingsInput class="mb-2" label="Level" tooltip="The character level for the trinket tooltips." :min="1" v-model="settingsStore.level" />
    <SettingsInput
      class="mb-2"
      label="Open filters on hovering the labels"
      tooltip="Open the filter dropdown when hovering the labels.<br/>This will also automatically hide it if the mouse leaves the dropdown."
      :tooltip-html="true"
      v-model="settingsStore.filterOpenOnHover"
    />
    <SettingsInput
      class="mb-2"
      label="Filter hide delay"
      tooltip="The delay before hiding the filter dropdown when the mouse leaves it.<br/>Value is in milliseconds.<br/>Set to 0 to immediately hide the dropdown."
      :tooltip-html="true"
      :class="{ hidden: !settingsStore.filterOpenOnHover }"
      v-model="settingsStore.filterHideDelay"
    />
    <SettingsInput
      class="mb-2"
      label="Filter height"
      tooltip="The height of the filter dropdown in percentage of the screen (between 0-100).<br/>Set to 0 to make it auto-size."
      :tooltip-html="true"
      :min="0"
      :max="100"
      v-model="settingsStore.filterHeight"
    />
    <SettingsInput
      class="mb-2"
      label="Save selected trinkets"
      tooltip="Save the selected trinket filters to local storage to keep it for the next time the page opens.<br/>URLs with filters will overwrite this setting and show them instead, BUT they are not saved until modified."
      :tooltip-html="true"
      v-model="settingsStore.saveTrinkets"
    />
    <SettingsInput
      class="mb-2"
      label="Save selected specializations"
      tooltip="Save the selected specializations filters to local storage to keep it for the next time the page opens.<br/>URLs with filters will overwrite this setting and show them instead, BUT they are not saved until modified."
      :tooltip-html="true"
      v-model="settingsStore.saveSpecs"
    />
  </main>
</template>
