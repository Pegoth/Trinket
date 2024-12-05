<!-- eslint-disable vue/multi-word-component-names -->
<script setup lang="ts">
import GridFilter from "@/components/GridFilter.vue"
import GridData from "@/components/GridData.vue"
</script>

<template>
  <Suspense>
    <template #default>
      <main class="container">
        <GridFilter class="m-2" />
        <GridData />
      </main>
    </template>
    <template #fallback>
      <main>
        <p>Loading...</p>
      </main>
    </template>
  </Suspense>
</template>
