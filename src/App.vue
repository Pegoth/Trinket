<script setup lang="ts">
import { computed } from "vue"
import { RouterLink, RouterView } from "vue-router"
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome"
import { faClipboard, faMoon, faSun } from "@fortawesome/free-solid-svg-icons"
import { useSettingsStore } from "@/stores/settingsStore"
import { GroupByMode, useFilterStore } from "@/stores/filterStore.ts"
import { initTooltipService } from "@/services/tooltipService.ts"
import data from "@/common/data"

const settingsStore = useSettingsStore()
const filterStore = useFilterStore()
const url = computed(() => {
  const url = new URL(window.location.href)
  url.searchParams.set("trinkets", [...filterStore.trinkets].join(","))
  url.searchParams.set("specs", [...filterStore.specs].join(","))
  url.searchParams.set("groupByMode", filterStore.groupByMode === GroupByMode.Spec ? "spec" : "trinket")
  return url.toString()
})

function padLeft(value: number) {
  const str = value.toString()
  return str.length >= 2 ? str : `${"0".repeat(2 - str.length)}${str}`
}

const versionText = computed(() => {
  if (data.lastUpdated == null) {
    return ""
  }

  const date = new Date(data.lastUpdated)
  return `Last updated: ${date.getFullYear()}-${padLeft(date.getMonth() + 1)}-${padLeft(date.getDate())}`
})

function setFilterClipboard() {
  navigator.clipboard.writeText(url.value)
}

// Change to light/dark theme based on settings
settingsStore.$subscribe(() => {
  document.documentElement.setAttribute("data-bs-theme", settingsStore.darkMode ? "dark" : "light")
})
document.documentElement.setAttribute("data-bs-theme", settingsStore.darkMode ? "dark" : "light")
initTooltipService()
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
            <div class="col-auto">
              <a
                :href="url"
                class="btn btn-sm btn-outline-success"
                data-bs-placement="top"
                title="Copy url with current filters to clipboard."
                @click.prevent="setFilterClipboard"
                target="_blank"
              >
                <FontAwesomeIcon :icon="faClipboard" />
              </a>
            </div>
            <div class="col-auto">
              <button
                type="button"
                class="btn btn-sm"
                :class="{ 'btn-outline-dark': !settingsStore.darkMode, 'btn-outline-light': settingsStore.darkMode }"
                data-bs-placement="bottom"
                title="Toggle between dark and light mode."
                @click="settingsStore.darkMode = !settingsStore.darkMode"
              >
                <FontAwesomeIcon :icon="settingsStore.darkMode ? faSun : faMoon" />
              </button>
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
