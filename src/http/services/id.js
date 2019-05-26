import axios from '../axios'

export const newGuid = () =>{
    return axios.post('/ids/guids')
}