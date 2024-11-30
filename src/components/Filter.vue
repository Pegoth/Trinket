<script setup lang="ts">
import { useAppSettings } from "@/stores/appSettings"
import { useFilter } from "@/stores/filter"
import { useData } from "@/stores/data"
import { useRoute } from "vue-router"

const appSettings = useAppSettings()
const data = useData()
const filter = useFilter()
const route = useRoute()

//#region Filter loading logic
// Load trinket filters
if (route.query.trinkets) {
  if (typeof route.query.trinkets === "string") {
    for (const trinket of route.query.trinkets.split(",")) {
      filter.trinkets.add(trinket)
    }
  } else {
    for (const trinket of route.query.trinkets) {
      if (trinket != null) {
        filter.trinkets.add(trinket.toString())
      }
    }
  }
} else {
  for (const trinket of appSettings.trinkets) {
    filter.trinkets.add(trinket)
  }
}

// Load spec filters
if (route.query.specs) {
  if (typeof route.query.specs === "string") {
    for (const spec of route.query.specs.split(",")) {
      filter.specs.add(spec)
    }
  } else {
    for (const spec of route.query.specs) {
      if (spec != null) {
        filter.specs.add(spec)
      }
    }
  }
} else {
  for (const spec of appSettings.specs) {
    filter.specs.add(spec)
  }
}
//#endregion

const init = await data.init()
if (init) console.error(init)
</script>

<template>
  <label>Trinkets</label>
  <div></div>
</template>
