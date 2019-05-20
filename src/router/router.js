import Index from '../index/index.vue'
import UAViewer from '../ua/ua-viewer.vue'
import GUIDGen from '../guidgen/guidgen.vue'

export default {
    routes: [
        { path: '/', component: Index },
        { path: '/ua', title: 'UA Viewer', component: UAViewer },
        { path: '/guidgen', title: 'GUID Gen', component: GUIDGen }
    ]
}