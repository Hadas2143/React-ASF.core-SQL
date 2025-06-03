import axios from "axios"

let url="https://localhost:7032/api/Shooping/";
export const SaveInShopR=(obj)=>{
    return axios.put(`${url}SaveInShop`,obj)
}
//get all Shooping
export const GetAllShopR=()=>{
    return axios.get(`${url}getAllShopping`)
}
