import { useState } from "react"
import { UptCategoryR } from "../axios/categoryAxios"
import { useLocation, useNavigate } from 'react-router-dom'

export const UpdateCategory=()=>{
    //for refresh
    const navigate = useNavigate()
    const location = useLocation()

    const [MyCtg,setMyCtg]=useState(
        {
            "idcategory": 0,
            "nameCategory": ""
        }
    )
    const Save =async()=>{
        let x=(await UptCategoryR(MyCtg,MyCtg.idcategory)).data
        if(x)
        {
            alert("😂") 
            const previousPath = location.pathname
            navigate('/')
            setTimeout(() => { 
                navigate('/category')
            }, 0)
        }
        else{
            alert("😤") 
        }
    }
    return <>
    <input className="form-control" type="txt" placeholder="name category" onBlur={(e)=>setMyCtg({...MyCtg,nameCategory:e.target.value})}/>
    <br></br>
    <input className="form-control" type="number" placeholder="id category" onBlur={(e)=>setMyCtg({...MyCtg,idcategory:e.target.value})}/>
    <br></br>
    <button className="btn btn-info" onClick={()=>Save()}>Update</button>
 </>
}