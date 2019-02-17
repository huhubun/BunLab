import Index from '../index/index.vue'
import UAViewer from '../ua/ua-viewer.vue'

export default {
    routes: [
        { path: '/', component: Index },
        { path: '/ua', title: 'UA Viewer', component: UAViewer }
    ]
}