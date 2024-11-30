<script setup lang="ts">
import Filter from "@/components/Filter.vue"
</script>

<template>
  <main>
    <Suspense>
      <template #default>
        <Filter />
      </template>
      <template #fallback>
        <p>Loading...</p>
      </template>
    </Suspense>
  </main>
</template>
