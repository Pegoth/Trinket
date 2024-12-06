import { defineStore } from "pinia"
import { parse, stringify } from "zipson"

export const useSettingsStore = defineStore("settingsStore", {
  state: () => ({
    darkMode: false,
    itemLevel: 626,
    level: 80,
    filterOpen: false,
    filterOpenOnHover: true,
    filterHideDelay: 250,
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
