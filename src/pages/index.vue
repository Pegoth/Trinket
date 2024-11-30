<script setup lang="ts">
import Filter from "@/components/Filter.vue"
import TrinketTable from "@/components/TrinketTable.vue"
import SpecTable from "@/components/SpecTable.vue"
import { GroupByMode, useFilterStore } from "@/stores/filterStore"

const filterStore = useFilterStore()
</script>

<template>
  <main>
    <Suspense>
      <template #default>
        <div>
          <Filter />
          <TrinketTable v-if="filterStore.groupByMode === GroupByMode.Trinket" />
          <SpecTable v-else-if="filterStore.groupByMode === GroupByMode.Spec" />
        </div>
      </template>
      <template #fallback>
        <p>Loading...</p>
      </template>
    </Suspense>
  </main>
</template>
