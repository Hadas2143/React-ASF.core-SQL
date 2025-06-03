import axios from "axios"

const url="https://localhost:7032/api/Customer/"
//get all customers
export const GetAllCustomerR=()=>{
    return axios.get(`${url}getCustomer`)
}

//check the customer with name & password
export const CheckCustomerR=(name,pass)=>{
    console.log("axios")
    return axios.get(`${url}checkCustomer/${name}/${pass}`)
}
//Get ID customer by password
export const GetIDCustomerByPassR=(pass)=>{
    // GetIDCustomerByPass/456
    return axios.get(`${url}GetIDCustomerByPass/${pass}`)
}


//delete costomer (by id)
export const DeleteCostomerR=(id)=>{
    return axios.delete(`${url}deleteCostomer/${id}`)
}

//add costomer to the list
export const AddCostomerR = (obj) => {
    return axios.put(`${url}addCustomer`, obj);
};  

//update costomer (with id)
export const UptCostomerR=(obj,id)=>{
    return axios.post(`${url}updateCostomer/${id}`,obj)
}