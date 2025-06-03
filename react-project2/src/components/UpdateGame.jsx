import { useEffect, useState } from "react"
import { UptGame } from "../axios/gameAxios"
import { useLocation, useNavigate } from 'react-router-dom'
import { GetAllCategoryR } from "../axios/categoryAxios"

export const UpdateGame=()=>{
    //for refresh
    const navigate = useNavigate()
    const location = useLocation()

    const [MyGame,setMyGame]=useState(
        {
            "idgame": 0,
            "game1": "",
            "idcategory": 0,
            "price": 0,
            "img": "",
            "qty": 0
        }
    )
    const Save=async()=>{
        let x=(await UptGame(MyGame,MyGame.idgame)).data
        if(x)
        {
           alert("😂") 
           const previousPath = location.pathname
           navigate('/')
           setTimeout(() => { 
                navigate('/game')
           }, 0)
        }
        else{
            alert("😤") 

        }
    }
    const [categoryList,setCategoryList]=useState([])
    const doGetAllCategory=async()=>{
        if(categoryList.length==0)
        {
            let x=(await GetAllCategoryR()).data
            setCategoryList(x)
        }
    }
    useEffect(()=>{
        doGetAllCategory()
    },[])
    return<>
    <input className="form-control" type="number" placeholder="idgame" onBlur={(e)=>setMyGame({...MyGame,idgame:e.target.value})}/>
    <br></br>
    <input className="form-control" type="txt" placeholder="game1" onBlur={(e)=>setMyGame({...MyGame,game1:e.target.value})}/>
    <br></br>
    <select 
                className="form-select" 
                onChange={(e)=>setMyGame({...MyGame,idcategory:e.target.value})}>
                {categoryList.map((e) => (
                    <option key={e.idcategory} value={e.idcategory}>
                         {e.nameCategory}
                    </option>
                ))}
            </select>
    <br></br>
    <input className="form-control" type="number" placeholder="price" onBlur={(e)=>setMyGame({...MyGame,price:e.target.value})}/>
    <br></br>
    <input className="form-control" type="txt" placeholder="img" onBlur={(e)=>setMyGame({...MyGame,img:e.target.value})}/>
    <br></br>
    <input className="form-control" type="number" placeholder="qty" onBlur={(e)=>setMyGame({...MyGame,qty:e.target.value})}/>
    <br></br>
    <button className="btn btn-info" onClick={()=>Save()}>Update</button>
    </>
}