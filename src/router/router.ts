import { createRouter, createWebHistory } from "vue-router"
import { routes } from "vue-router/auto-routes"

// Remove trailing slash from base path
let basePath = location.pathname.replace(/\/$/, "")

// Remove all routes from base path
routes.map((route) => new RegExp(`${route.path.replace(/^\/|\/$/g, "")}$`)).forEach((path) => (basePath = basePath.replace(path, "")))

const router = createRouter({
  history: createWebHistory(basePath),
  routes
})

export default router
