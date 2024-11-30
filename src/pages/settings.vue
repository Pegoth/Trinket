<script setup lang="ts">
import { useSettingsStore } from "@/stores/settingsStore"

const settingsStore = useSettingsStore()
</script>

<template>
  <main>
    <h1>Settings</h1>
    <div>
      <input type="checkbox" id="dark-mode" v-model="settingsStore.darkMode" />
      <label for="dark-mode">Dark Mode</label>
    </div>
    <div>
      <label for="item-level">Item Level</label>
      <input type="number" id="item-level" v-model="settingsStore.itemLevel" />
    </div>
    <div>
      <label for="level">Level</label>
      <input type="number" id="level" v-model="settingsStore.level" />
    </div>
    <div>
      <input type="checkbox" id="save-trinkets" v-model="settingsStore.saveTrinkets" />
      <label for="save-trinkets">Save selected trinkets</label>
    </div>
    <div>
      <input type="checkbox" id="save-specs" v-model="settingsStore.saveSpecs" />
      <label for="save-specs">Save selected specializations</label>
    </div>
  </main>
</template>
