import { Outlet, useNavigate } from "react-router-dom"
import { useContext, useEffect, useState } from "react"
import MyCotext from "../Context"
import { GetAllShopR } from "../axios/ShoopingAxios"
import {GetIDCustomerByPassR} from "../axios/customerAxios"

export const MyAccount=()=>{
    const passUser=useContext(MyCotext).passUser

    const [arrShop, setArrShop] = useState([]);

    let myNevigate = useNavigate()

    const func= async()=>{
        let myPassUser=(await GetIDCustomerByPassR(passUser)).data
        let arrShopH=(await GetAllShopR()).data
        arrShopH=arrShopH.filter((item) => item.idcustomer === myPassUser)
        setArrShop(arrShopH)
    }
    useEffect(()=>{
        func()
    },[])
    return <>
    <table className="table">
    <thead>
    <tr>
        <th>ID buy</th>
        <th>ID customer</th>
        <th>Date buy</th>
        <th>Price</th>
    </tr>
    </thead>
    <tbody>
        {arrShop.map((x,i)=><tr key={i}>
        <button className="btn btn-outline-wight w-25 mb-2" onClick={()=>{myNevigate(`shopInfo/${arrShop}/${x.idbuy}`)}}><td>{x.idbuy}</td></button>
        <td>{x.idcustomer}</td>
        <td>{x.dateBuy}</td>
        <td>{x.price}</td>
    </tr>)}
    </tbody>     
    </table>
<Outlet></Outlet>
</>
}