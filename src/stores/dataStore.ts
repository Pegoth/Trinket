import { defineStore } from "pinia"
import { parse, stringify } from "zipson"
import axios from "axios"

//#region Interfaces
export interface IVersion {
  lastUpdated: string
}

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
  specs: { [className: string]: string[] }
  items: { [itemName: string]: number }
  wowhead: { [specName: string]: IWowheadData[] }
  bloodmallet: { [specName: string]: { [targets: string]: IBloodmalletData[] } }
}
//#endregion

//#region Setup
// Check if in development mode
let isDev = false
try {
  isDev = process.env.NODE_ENV === "development"
} catch {}

const client = axios.create({
  baseURL: isDev ? "/trinketData/" : "https://raw.githubusercontent.com/Pegoth/Trinket/refs/heads/master/trinketData/"
})
//#endregion

export const useDataStore = defineStore("dataStore", {
  state: () => ({
    version: null as string | null,
    lastCheck: null as string | null,
    data: null as IData | null
  }),
  actions: {
    /**
     * Tries to initialize data from github, if already has the same version as the one in github, it does nothing.
     * @returns The error if there was one, otherwise null.
     */
    async init() {
      try {
        // If last check was less than a minute ago, do nothing
        if (this.lastCheck != null && new Date().getDate() - new Date(this.lastCheck).getDate() < 60000) {
          return null
        }

        // Get version info
        const versionResp = await client.get<IVersion>("data.version.json", {
          headers: {
            "Cache-Control": "no-cache",
            Pragma: "no-cache",
            Expires: "0"
          }
        })

        // If the request failed, throw an error
        if (versionResp.status !== 200) {
          throw new Error("Failed to get version.")
        }

        // Check if newer version is available
        const version = versionResp.data.lastUpdated
        if (this.version == null || new Date(version) > new Date(this.version)) {
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

          this.version = version
          this.data = dataResp.data
        }

        this.lastCheck = new Date().toISOString()
        return null
      } catch (err) {
        this.lastCheck = new Date().toISOString()
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
  },
  persist: {
    serializer: {
      deserialize: parse,
      serialize: stringify
    }
  }
})
