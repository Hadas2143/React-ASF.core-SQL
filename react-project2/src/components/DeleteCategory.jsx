import { useLocation, useNavigate,useParams } from "react-router-dom"
import { useEffect } from "react"
import { DeleteCategoryR } from "../axios/categoryAxios"

export const DeleteCategory=()=>{
    let myParams=useParams()
    //for refresh
    const navigate = useNavigate()
    const location = useLocation()

    const Save=async()=>{
        let x=(await DeleteCategoryR(myParams.id)).data
        if(x===true)
            {
                console.log(x)
                alert("😂") 
                navigate('/category')
            }
    }
    
    useEffect(()=>{
        Save()
    },[])
    return <></>
}