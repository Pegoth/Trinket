<!-- eslint-disable vue/multi-word-component-names -->
<script setup lang="ts">
import GridFilter from "@/components/GridFilter.vue"
import GridData from "@/components/GridData.vue"
</script>

<template>
  <main class="container">
    <Suspense>
      <template #default>
        <div>
          <GridFilter />
          <GridData />
        </div>
      </template>
      <template #fallback>
        <p>Loading...</p>
      </template>
    </Suspense>
  </main>
</template>
