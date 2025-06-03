import { useEffect, useState } from "react"
import { AddGameR } from "../axios/gameAxios"
import { useLocation, useNavigate } from 'react-router-dom'
import { GetAllCategoryR } from "../axios/categoryAxios"

export const AddGame=()=>{
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
        debugger
        try{
            if(MyGame.price=="")
                MyGame.price=0
            if(MyGame.qty=="")
                MyGame.qty=0
            setMyGame(MyGame)
            let x=(await AddGameR(MyGame)).data
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
        catch(error)
        {
            alert("please input all parameters, you must input game,category")
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
        <button className="btn btn-info" onClick={()=>Save()}>Add</button>
        </>
}