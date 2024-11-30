<script setup lang="ts">
import { useAppSettings } from "@/stores/appSettings"

const appSettings = useAppSettings()
</script>

<template>
  <main>
    <h1>Settings</h1>
    <div>
      <input type="checkbox" id="dark-mode" v-model="appSettings.darkMode" />
      <label for="dark-mode">Dark Mode</label>
    </div>
    <div>
      <label for="item-level">Item Level</label>
      <input type="number" id="item-level" v-model="appSettings.itemLevel" />
    </div>
    <div>
      <label for="level">Level</label>
      <input type="number" id="level" v-model="appSettings.level" />
    </div>
    <div>
      <input type="checkbox" id="save-trinkets" v-model="appSettings.saveTrinkets" />
      <label for="save-trinkets">Save selected trinkets</label>
    </div>
    <div>
      <input type="checkbox" id="save-specs" v-model="appSettings.saveSpecs" />
      <label for="save-specs">Save selected specializations</label>
    </div>
  </main>
</template>
