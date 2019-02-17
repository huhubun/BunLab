import Vue from 'vue'
import VueRouter from 'vue-router'
import App from './app.vue'
import Index from './index/index.vue'
import UAViewer from './ua/ua-viewer.vue'

Vue.use(VueRouter)

const router = new VueRouter({
    mode: 'history',
    routes: [
        { path: '/', component: Index },
        { path: '/ua', component: UAViewer }
    ]
})

new Vue({
    router,
    render: (h) => h(App)
}).$mount('#app');