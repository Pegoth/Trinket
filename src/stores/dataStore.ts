import { defineStore } from "pinia"
import axios from "axios"

//#region Interfaces
export interface IWowheadData {
  item: string
  tier: string
  note: string
}

export interface IBloodmalletData {
  item: string
  tier: number
}

export interface IData {
  lastUpdated: string
  specs: { [className: string]: string[] }
  items: { [itemName: string]: number }
  wowhead: { [specName: string]: IWowheadData[] }
  bloodmallet: { [specName: string]: { [targets: string]: IBloodmalletData[] } }
}
//#endregion

//#region Setup
const client = axios.create({
  baseURL: "."
})
//#endregion

export const useDataStore = defineStore("dataStore", {
  state: () => ({
    data: null as IData | null
  }),
  actions: {
    /**
     * Tries to initialize data from github, if already has the same version as the one in github, it does nothing.
     * @returns The error if there was one, otherwise null.
     */
    async init() {
      try {
        if (this.data == null) {
          const dataResp = await client.get<IData>("data.json", {
            headers: {
              "Cache-Control": "no-cache",
              Pragma: "no-cache",
              Expires: "0"
            }
          })

          // If the request failed, throw an error
          if (dataResp.status !== 200) {
            throw new Error("Failed to get data.")
          }

          this.data = dataResp.data
        }
      } catch (err) {
        return err
      }
    },
    findClassForSpec(spec: string) {
      if (this.data == null) {
        return null
      }

      for (const className in this.data.specs) {
        if (this.data.specs[className].some((partialSpecName) => spec.toLowerCase().includes(partialSpecName.toLowerCase()))) {
          return className
        }
      }
      return null
    }
  }
})
