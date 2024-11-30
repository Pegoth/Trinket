<script setup lang="ts">
import { RouterLink, RouterView } from "vue-router"
</script>

<template>
  <header>
    <nav>
      <RouterLink to="/">Home</RouterLink>
      <RouterLink to="/settings">Settings</RouterLink>
    </nav>
  </header>
  <RouterView />
</template>
