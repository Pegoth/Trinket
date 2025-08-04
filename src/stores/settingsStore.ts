import { defineStore } from "pinia"
import { parse, stringify } from "zipson"

export const useSettingsStore = defineStore("settingsStore", {
  state: () => ({
    darkMode: false,
    itemLevel: 723,
    level: 80,
    filterOpen: false,
    filterOpenOnHover: true,
    filterHideDelay: 250,
    filterHeight: 70,
    trinketSearch: "",
    saveTrinkets: true,
    trinkets: [] as string[],
    specSearch: "",
    saveSpecs: true,
    specs: [] as string[]
  }),
  persist: {
    serializer: {
      deserialize: parse,
      serialize: stringify
    }
  }
})
