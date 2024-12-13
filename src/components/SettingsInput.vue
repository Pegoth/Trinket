<script setup lang="ts">
import { useId, defineModel, onMounted } from "vue"
import { Tooltip } from "bootstrap"

const id = useId()
const props = defineProps<{
  label: string
  tooltip?: string
  tooltipPlacement?: string
  tooltipHtml?: boolean
  min?: number
  max?: number
}>()
const model = defineModel<string | boolean | number>({
  required: true
})

// Turn on tooltips
onMounted(() => {
  document.querySelectorAll('[data-bs-toggle="tooltip"]').forEach((tooltip) => {
    Tooltip.getOrCreateInstance(tooltip)
  })
})
</script>

<template>
  <div :class="{ 'form-check': typeof model == 'boolean' }" v-bind="$attrs">
    <template v-if="typeof model == 'boolean'">
      <input type="checkbox" :id="id" class="form-check-input" v-model="model" />
      <label
        :for="id"
        class="form-check-label"
        :data-bs-toggle="props.tooltip ? 'tooltip' : ''"
        :data-bs-placement="props.tooltipPlacement ?? 'top'"
        :data-bs-html="props.tooltipHtml ?? false"
        :title="props.tooltip"
        >{{ props.label }}</label
      >
    </template>
    <template v-else>
      <label :for="id" class="form-label">{{ props.label }}</label>
      <input
        :type="typeof model == 'number' ? 'number' : 'text'"
        :id="id"
        class="form-control"
        :data-bs-toggle="props.tooltip ? 'tooltip' : ''"
        :data-bs-placement="props.tooltipPlacement ?? 'top'"
        :data-bs-html="props.tooltipHtml ?? false"
        :title="props.tooltip"
        :min="props.min"
        :max="props.max"
        v-model="model"
      />
    </template>
  </div>
</template>
