import { defineStore } from "pinia"

export const useAppSettings = defineStore("appSettings", {
  state: () => ({
    darkMode: false,
    itemLevel: 626,
    level: 80,
    saveTrinkets: true,
    trinkets: [],
    saveSpecs: true,
    specs: []
  }),
  persist: true
})
