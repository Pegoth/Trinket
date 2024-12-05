import { defineStore } from "pinia"
import { parse, stringify } from "zipson"

export const useSettingsStore = defineStore("settingsStore", {
  state: () => ({
    darkMode: false,
    itemLevel: 626,
    level: 80,
    filterOpenOnHover: true,
    filterHideDelay: 250,
    saveTrinkets: true,
    trinkets: [] as string[],
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
