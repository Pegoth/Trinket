import { defineStore } from "pinia"

export const useFilter = defineStore("filter", {
  state: () => ({
    trinkets: new Set<string>(),
    specs: new Set<string>()
  })
})
