import { onMounted } from "vue"
import { Tooltip } from "bootstrap"

// Selector that will find elements that has tooltip
const tooltipSelector = "[data-bs-original-title],[title]"

// Tooltip options
const options = <Tooltip.Options>{
  trigger: "hover",
  delay: {
    show: 250
  }
}

// List of all active tooltips (not necessarily visible)
const tooltips = new Set<Tooltip>()
export { tooltips }

// Load tooltip for the given element (only if it has title/data-bs-original-title attribute)
function loadTooltip(element: Element) {
  const tooltip = Tooltip.getInstance(element)
  if (!tooltip) {
    if (element.hasAttribute("data-bs-original-title") || element.hasAttribute("title")) {
      tooltips.add(new Tooltip(element, options))
    }
    return
  }

  const title = element.getAttribute("title")
  if (!title) return

  element.setAttribute("data-bs-original-title", title)
  element.removeAttribute("title")
}

let observerInitialized = false

// Initialize the tooltip service, should be called in App.vue
export function initTooltipService() {
  onMounted(() => {
    // Load tooltips on initial render
    document.querySelectorAll(tooltipSelector).forEach(loadTooltip)

    // Do nothing if the observer is already created
    if (observerInitialized) return

    // Create observer that checks for creation/deletion and title change
    const observer = new MutationObserver((mutations) => {
      mutations.forEach((mutation) => {
        // On title change move "title" attribute to "data-bs-original-title" to update tooltip
        if (mutation.type === "attributes") {
          const element = mutation.target as HTMLElement
          if (mutation.attributeName === "title" && element) {
            loadTooltip(element)
          }
        } else if (mutation.type === "childList") {
          // Create new tooltips and add them to the list
          mutation.addedNodes.forEach((node) => {
            if (!(node instanceof HTMLElement)) return

            node.querySelectorAll(tooltipSelector).forEach(loadTooltip)
          })

          // Destroy removed tooltips and remove them from the list
          mutation.removedNodes.forEach((node) => {
            if (!(node instanceof HTMLElement) || node.querySelectorAll == undefined) return

            node.querySelectorAll(tooltipSelector).forEach((element) => {
              const tooltip = Tooltip.getInstance(element)
              if (!tooltip) return

              tooltip.dispose()
              tooltips.delete(tooltip)
            })
          })
        }
      })
    })
    observer.observe(document.documentElement, {
      childList: true,
      subtree: true,
      attributes: true,
      attributeFilter: ["title"]
    })
    observerInitialized = true
  })
}

// Hide all tooltips
export function hideAll() {
  tooltips.forEach((tooltip) => tooltip.hide())
}
