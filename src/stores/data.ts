import axios from "axios"
import { defineStore } from "pinia"

export interface IVersion {
  lastUpdated: string
}

export interface IWowheadData {
  item: number
  tier: string
  note: string
}

export interface IBloodmalletData {
  item: number
  tier: number
}

export interface IData {
  spec: { [key: string]: string[] }
  wowhead: { [key: string]: IWowheadData[] }
  bloodmallet: { [key: string]: { [key: string]: IBloodmalletData[] } }
}

console.log(process.env.NODE_ENV)

const client = axios.create({
  baseURL:
    process?.env?.NODE_ENV === "development"
      ? "http://localhost/trinketData/"
      : "https://raw.githubusercontent.com/Pegoth/Trinket/refs/heads/master/trinketData/"
})

export const useData = defineStore("data", {
  state: () => ({
    version: null as Date | null,
    data: null as IData | null
  }),
  actions: {
    /**
     * Tries to initialize data from github, if already has the same version as the one in github, it does nothing.
     * @returns The error if there was one, otherwise null.
     */
    async init() {
      try {
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
        const version = new Date(versionResp.data.lastUpdated)
        if (this.version == null || version > this.version) {
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

        return null
      } catch (err) {
        return err
      }
    }
  },
  persist: true
})
