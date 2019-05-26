import axios from 'axios'

axios.defaults.baseURL = `${window.bunLabConfig.api.url}/${window.bunLabConfig.api.version}`

export default axios