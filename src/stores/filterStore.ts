import { defineStore } from "pinia"

export enum GroupByMode {
  Trinket,
  Spec
}

export enum OrderByColumn {
  ItemOrSpec,
  Wowhead,
  Bloodmallet1,
  Bloodmallet3,
  Bloodmallet5
}

export enum OrderByDirection {
  Asc,
  Desc
}

export const useFilterStore = defineStore("filterStore", {
  state: () => ({
    groupByMode: GroupByMode.Trinket,
    orderBy: [
      { column: OrderByColumn.Wowhead, direction: OrderByDirection.Asc },
      { column: OrderByColumn.Bloodmallet1, direction: OrderByDirection.Asc }
    ] as { column: OrderByColumn; direction: OrderByDirection }[],
    trinkets: new Set<string>(),
    specs: new Set<string>()
  }),
  actions: {
    /**
     * Rotates the sorting mode for the given column: Asc -> Desc -> None -> Asc -> ...
     * If removeOthers is true, it will remove all other sortings BEFORE toggling the given column.
     * @param column Which column to sort by.
     * @param removeOthers True to remove all other sortings.
     */
    toggleOrderBy(column: OrderByColumn, removeOthers?: boolean) {
      if (removeOthers === true) {
        const multiToSingleChange = this.orderBy.some((by) => by.column != column) && this.orderBy.some((by) => by.column == column)
        this.orderBy = this.orderBy.filter((by) => by.column == column)

        // If there were other sortings before, do nothing else, don't change the order (changing from multi sorting to single)
        if (multiToSingleChange) {
          return
        }
      }

      const index = this.orderBy.findIndex((by) => by.column == column)
      if (index >= 0) {
        if (this.orderBy[index].direction == OrderByDirection.Asc) {
          this.orderBy[index].direction = OrderByDirection.Desc
        } else {
          this.orderBy.splice(index, 1)
        }
      } else {
        this.orderBy.push({
          column,
          direction: OrderByDirection.Asc
        })
      }
    },
    /**
     * Gets the direction of sorting for the given column.
     * @param column The column to get the direction of.
     * @returns Returns the direction and 1 based index of the column in the sorting order or null if not ordered by it.
     */
    getDirection(column: OrderByColumn) {
      const index = this.orderBy.findIndex((by) => by.column == column)
      return index >= 0
        ? {
            direction: this.orderBy[index].direction,
            index: this.orderBy.length > 1 ? index + 1 : null
          }
        : null
    }
  },
  persist: {
    pick: ["groupByMode", "orderBy"]
  }
})
