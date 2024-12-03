import { createApp } from "vue"
import { createPinia } from "pinia"
import piniaPluginPersistedstate from "pinia-plugin-persistedstate"
import {} from "bootstrap"

import App from "./App.vue"
import router from "./router/router"

import "./assets/styles.scss"

//#region wowhead script TS type fix
declare global {
  interface Window {
    $WowheadPower: {
      refreshLinks: () => void
    }
  }
}
//#endregion

const app = createApp(App)

const pinia = createPinia()
pinia.use(piniaPluginPersistedstate)
app.use(pinia)
app.use(router)

app.mount("#app")
