import Vue from 'vue'
import VueRouter from 'vue-router'
import App from './app.vue'
import routers from './router/router'
import api from './http'

import 'vue-awesome/icons/regular/circle'
import 'vue-awesome/icons/circle-notch'
import Icon from 'vue-awesome/components/Icon.vue'

Vue.use(VueRouter)
Vue.use(api)

Vue.component('v-icon', Icon)

const router = new VueRouter({
    mode: 'history',
    routes: routers.routes
})

new Vue({
    router,
    render: (h) => h(App)
}).$mount('#app');