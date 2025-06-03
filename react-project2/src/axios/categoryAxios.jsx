import axios from "axios"

const url="https://localhost:7032/api/Category/"

//get all category
export const GetAllCategoryR=()=>{
    return axios.get(`${url}getCategory`)
}
//get category by id 
export const GetByIdR=(id)=>{
    return axios.get(`${url}getById/${id}`)
}
//delete category (by id)
export const DeleteCategoryR=(id)=>{
    return axios.delete(`${url}deleteCategory/${id}`)
}
//add category to the list
export const AddCategoryR=(obj)=>{
    return axios.put(`${url}add`,obj)
}
//update category (with id)
export const UptCategoryR=(obj,id)=>{
    return axios.post(`${url}updateCategory/${id}`,obj)
}