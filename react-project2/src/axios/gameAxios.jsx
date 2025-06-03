import axios from "axios"

const url="https://localhost:7032/api/Game/"
//get all Game
export const GetAllGame=()=>{
    console.log("in axios")
    debugger
    return axios.get(`${url}getGame`)
}
//get Game by id
export const GetGameById=(id)=>{
    return axios.get(`${url}getById/${id}`)
}
//get Game by category
export const GetGameByCategory=(id)=>{
    return axios.get(`${url}getByCategory/${id}`)
}
//delete Game (by id)
export const DeleteGameR=(id)=>{
    return axios.delete(`${url}deleteGame/${id}`)
}
//add Game to the list
export const AddGameR=(obj)=>{
    return axios.put(`${url}addGame`,obj)
}
//update Game (with id)
export const UptGame=(obj,id)=>{
    return axios.post(`${url}updateGame/${id}`,obj)
}
//update Game (with qty)
export const UptQty=(obj)=>{
    return axios.post(`${url}uptMyQty`,obj)
}