import data from "@/assets/data.json"

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

const typedData = data as IData

export function findClassForSpec(spec: string) {
  if (typedData == null) {
    return null
  }

  for (const className in typedData.specs) {
    if (typedData.specs[className].some((partialSpecName) => spec.toLowerCase().includes(partialSpecName.toLowerCase()))) {
      return className
    }
  }
  return null
}

export default typedData
