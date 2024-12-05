import { createRouter, createWebHistory } from "vue-router"
import { routes } from "vue-router/auto-routes"

const router = createRouter({
  history: createWebHistory(location.pathname),
  routes
})

export default router
