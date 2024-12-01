<script setup lang="ts">
import Filter from "@/components/Filter.vue"
import TrinketTable from "@/components/TrinketTable.vue"
</script>

<template>
  <main>
    <Suspense>
      <template #default>
        <div>
          <Filter />
          <TrinketTable />
        </div>
      </template>
      <template #fallback>
        <p>Loading...</p>
      </template>
    </Suspense>
  </main>
</template>
