import { defineStore } from "pinia"
import { parse, stringify } from "zipson"

export const useSettingsStore = defineStore("settingsStore", {
  state: () => ({
    darkMode: false,
    itemLevel: 626,
    level: 80,
    saveTrinkets: true,
    trinkets: [] as number[],
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
