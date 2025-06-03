import { useContext, useState } from "react"
import { AddCostomerR } from "../axios/customerAxios"
import MyCotext from "../Context"

export const Listing=()=>{
    const setCurrUser=useContext(MyCotext).setCurrUser
    const [customer,setCustomer]=useState(
        {
            "idcustomer": 0,
            "nameCustomer": "",
            "pass": "",
            "creditCard": "",
            "expirationDate": "",
            "cvv": ""
        })
    const AddC=async()=>{
        alert("in addC")
        debugger
        let x=(await AddCostomerR(customer)).data
        if(x)
        {
            alert("😂") 
            setCurrUser(customer.nameCustomer)
        }
        else{
            alert("😤") 
        }
    }
    return <>
    <input className="form-control" type="txt" placeholder="customer name" onBlur={(e)=>setCustomer({...customer,nameCustomer:e.target.value})}/>
    <br></br>
    <input className="form-control" type="txt" placeholder="password" onBlur={(e)=>setCustomer({...customer,pass:e.target.value})}/>
    <br></br>
    <input className="form-control" type="txt" placeholder="munber credit card" onBlur={(e)=>setCustomer({...customer,creditCard:e.target.value})}/>
    <br></br>
    <input className="form-control" type="date" placeholder="expirationDate" onBlur={(e)=>setCustomer({...customer,expirationDate:e.target.value})}/>
    <br></br>
    <input className="form-control" type="txt" placeholder="cvv" onBlur={(e)=>setCustomer({...customer,cvv:e.target.value})}/>
    <br></br>
    <button className="btn btn-info" onClick={()=>AddC()}>Add</button>
    </>
}