<script setup lang="ts">
import { defineProps } from "vue"

const props = defineProps({
  value: {
    type: Number,
    required: true,
    validator: (value: number) => value >= 0 && value <= 2
  }
})
</script>

<template>
  <input type="checkbox" :checked="props.value === 1" :indeterminate="props.value === 2" v-bind="$attrs" />
</template>
