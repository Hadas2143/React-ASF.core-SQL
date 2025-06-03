import { useState } from "react"
import { AddCategoryR } from "../axios/categoryAxios"
import { useLocation, useNavigate } from 'react-router-dom';

export const Addcategory=()=>{
    //for refresh
    const navigate = useNavigate();
    const location = useLocation();

    const [MyCtg,setMyCtg]=useState(
        {
            "idcategory": 0,
            "nameCategory": ""
        }
    )
    const Save =async()=>{
        let x=(await AddCategoryR(MyCtg)).data
        if(x)
        {
            alert("😂") 
            const previousPath = location.pathname
            navigate('/')
            setTimeout(() => { 
                navigate('/category')

            }, 0);

        }
        else{
            alert("😤") 
        }
    }
    return <>
    <input className="form-control" type="txt" placeholder="name category" onBlur={(e)=>setMyCtg({...MyCtg,nameCategory:e.target.value})}/>
    <br></br>
    <button className="btn btn-info" onClick={()=>Save()}>Add</button>
 </>
}