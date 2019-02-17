import Vue from 'vue'
import VueRouter from 'vue-router'
import App from './app.vue'
import routers from './router/router' 

Vue.use(VueRouter)

const router = new VueRouter({
    mode: 'history',
    routes: routers.routes
})

new Vue({
    router,
    render: (h) => h(App)
}).$mount('#app');