import { useEffect, useState } from "react"
import { DeleteGameR } from "../axios/gameAxios"
import { useLocation, useNavigate,useParams } from "react-router-dom"

export const DeleteGame=()=>{
    debugger
    let myParams=useParams()
    //for refresh
    const navigate = useNavigate()
    const location = useLocation()

    const [is,setIs]=useState(false)
    const Save=async()=>{
        if(is===false)
            {
                let x=(await DeleteGameR(myParams.id)).data
                if(x===true)
                    {
                        alert("😂") 
                        setIs(true)
                        navigate('/game')
                    }
                    
             }
        else{
                alert("😤")
            }
    }
    
    useEffect(()=>{
        Save()
    },[])
    return <></>
}