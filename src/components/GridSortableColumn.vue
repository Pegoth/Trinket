<script setup lang="ts">
import { computed, type PropType } from "vue"
import { GroupByMode, OrderByColumn, OrderByDirection, useFilterStore } from "@/stores/filterStore"

const filterStore = useFilterStore()
const props = defineProps({
  column: {
    type: Number as PropType<OrderByColumn>,
    required: true
  }
})
const text = computed(() => {
  switch (props.column) {
    case OrderByColumn.ItemOrSpec:
      switch (filterStore.groupByMode) {
        case GroupByMode.Trinket:
          return "Spec / class"
        case GroupByMode.Spec:
          return "Trinket"
        default:
          return "Unknown"
      }
    case OrderByColumn.Wowhead:
      return "Wowhead"
    case OrderByColumn.Bloodmallet1:
      return "1"
    case OrderByColumn.Bloodmallet3:
      return "3"
    case OrderByColumn.Bloodmallet5:
      return "5"
    default:
      return "Unknown"
  }
})
const rowspan = computed(() => {
  switch (props.column) {
    case OrderByColumn.ItemOrSpec:
    case OrderByColumn.Wowhead:
      return 2
    case OrderByColumn.Bloodmallet1:
    case OrderByColumn.Bloodmallet3:
    case OrderByColumn.Bloodmallet5:
    default:
      return 1
  }
})
const direction = computed(() => filterStore.getDirection(props.column))

function headerTextClicked(event: MouseEvent) {
  // Remove visual text selection
  document.getSelection()?.removeAllRanges()

  // Order by this column
  filterStore.toggleOrderBy(props.column, !event.ctrlKey && !event.altKey && !event.shiftKey)
}
</script>

<template>
  <th class="auto-size" :rowspan="rowspan" v-bind="$attrs">
    <div class="d-inline clickable" @click="headerTextClicked">
      <span>{{ text }}</span>
      <span v-if="direction != null">{{ direction.direction == OrderByDirection.Asc ? "↓" : "↑" }}</span>
      <span class="order-by-index" v-if="direction != null && direction.index != null">{{ direction.index }}</span>
    </div>
  </th>
</template>

<style scoped>
.order-by-index {
  font-size: 0.5em;
}
.auto-size {
  width: 1px;
  white-space: nowrap;
  overflow: hidden;
}
</style>
