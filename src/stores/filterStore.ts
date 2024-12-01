import { defineStore } from "pinia"

export enum GroupByMode {
  Trinket,
  Spec
}

export const useFilterStore = defineStore("filterStore", {
  state: () => ({
    groupByMode: GroupByMode.Trinket,
    trinkets: new Set<string>(),
    specs: new Set<string>()
  }),
  persist: {
    pick: ["groupByMode"]
  }
})
