import axios from "axios"

const url="https://localhost:7032/api/Information/"
//get all information
export const GetAllInformationR=()=>{
    return axios.get(`${url}getInfo`)
}
//delete Information (by id)
export const DeleteInformationR=(id)=>{
    return axios.delete(`${url}deleteInfo/${id}`)
}
//add Information to the list
export const AddInformationrR=(obj)=>{
    return axios.put(`${url}addInfo`,obj)
}
//update Information (with id)
export const UptInformationR=(obj,id)=>{
    return axios.post(`${url}uptInfo/${id}`,obj)
}
// save shopping details iin information
export const SaveInIformationR=(id,cart)=>{
    return axios.put(`${url}SaveInIformation/${id}`,cart)
}
//get all information with thid id buy
export const GetInformationByIDR=(id)=>{
    return axios.get(`${url}GetInfoByID/${id}`)
}