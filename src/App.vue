<script setup lang="ts">
import { computed } from "vue"
import { RouterLink, RouterView } from "vue-router"
import { useSettingsStore } from "@/stores/settingsStore"
import data from "@/common/data"

const settingsStore = useSettingsStore()

function padLeft(value: number) {
  const str = value.toString()
  return str.length >= 2 ? str : `${"0".repeat(2 - str.length)}${str}`
}

const versionText = computed(() => {
  if (data.lastUpdated == null) {
    return ""
  }

  const date = new Date(data.lastUpdated)
  return `Last updated: ${date.getFullYear()}-${padLeft(date.getMonth() + 1)}-${padLeft(date.getDate())} ${padLeft(date.getHours())}:${padLeft(date.getMinutes())}:${padLeft(date.getSeconds())}`
})

// Change to light/dark theme based on settings
settingsStore.$subscribe(() => {
  document.documentElement.setAttribute("data-bs-theme", settingsStore.darkMode ? "dark" : "light")
})
document.documentElement.setAttribute("data-bs-theme", settingsStore.darkMode ? "dark" : "light")
</script>

<template>
  <header>
    <nav
      class="navbar navbar-expand-lg"
      :class="{
        'navbar-light': !settingsStore.darkMode,
        'bg-light': !settingsStore.darkMode,
        'navbar-dark': settingsStore.darkMode,
        'bg-dark': settingsStore.darkMode
      }"
    >
      <div class="container">
        <RouterLink class="navbar-brand" to="/">Trinket</RouterLink>
        <button
          class="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarSupportedContent"
          aria-controls="navbarSupportedContent"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
          <ul class="navbar-nav me-auto mb-2 mb-lg-0">
            <li class="nav-item">
              <RouterLink class="nav-link" to="/settings">Settings</RouterLink>
            </li>
          </ul>
          <div class="row">
            <div class="col-auto" v-if="versionText != ''">
              <span class="navbar-text">{{ versionText }}</span>
            </div>
            <div class="col-auto form-check form-switch">
              <input type="checkbox" id="dark-mode" class="form-check-input" v-model="settingsStore.darkMode" />
              <label for="dark-mode" class="form-check-label">Dark Mode</label>
            </div>
          </div>
        </div>
      </div>
    </nav>
  </header>
  <RouterView />
</template>

<style lang="css" scoped>
.router-link-active {
  font-weight: bold !important;
}

input[type="checkbox"] {
  margin-top: 0.4em;
}
</style>
