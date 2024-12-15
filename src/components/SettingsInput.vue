<script setup lang="ts">
import { onMounted, useId } from "vue"
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
const modelType = typeof model.value
const allowedKeys = ["Backspace", "Delete", "ArrowLeft", "ArrowRight", "ArrowUp", "ArrowDown", "Tab", "Enter", "Escape", "Home", "End", "Insert"]

function preventNonNumeric(event: KeyboardEvent) {
  if (modelType !== "number") return
  if (
    !/^\d+$/.test(event.key) &&
    !allowedKeys.includes(event.key) &&
    !(event.ctrlKey && (event.key === "v" || event.key === "c" || event.key === "x" || event.key === "a"))
  ) {
    event.preventDefault()
    return
  }

  if (event.key === "Backspace" || event.key === "Delete" || (event.ctrlKey && event.key === "v")) {
    setTimeout(() => {
      if (model.value === "" || isNaN(Number(model.value))) {
        model.value = 0
      } else {
        model.value = Number(model.value)
      }
    }, 10)
  }
}

// Turn on tooltips
onMounted(() => {
  document.querySelectorAll('[data-bs-toggle="tooltip"]').forEach((tooltip) => {
    Tooltip.getOrCreateInstance(tooltip)
  })
})
</script>

<template>
  <div :class="{ 'form-check': modelType == 'boolean' }" v-bind="$attrs">
    <template v-if="modelType == 'boolean'">
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
        :type="modelType == 'number' ? 'number' : 'text'"
        :id="id"
        class="form-control"
        :data-bs-toggle="props.tooltip ? 'tooltip' : ''"
        :data-bs-placement="props.tooltipPlacement ?? 'top'"
        :data-bs-html="props.tooltipHtml ?? false"
        :title="props.tooltip"
        :min="props.min"
        :max="props.max"
        v-model="model"
        @keydown="preventNonNumeric"
        @keyup="preventNonNumeric"
      />
    </template>
  </div>
</template>
