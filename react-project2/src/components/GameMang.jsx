import { useEffect, useState } from "react"
import { GetAllGame } from "../axios/gameAxios"
import { Link, Outlet } from "react-router-dom"

export const GameMang=()=>{
    //for intreduce a games in table
    const [listGame,setListGame]=useState([])
    const doGetAllGame=async()=>{
        if(listGame.length==0)
            {
                let x=(await GetAllGame()).data
                setListGame(x)
            }
    }
    useEffect(()=>{
        doGetAllGame()
    },[])
    
    return <>
     <table className="table">
<thead>
    <tr>
        <th>id</th>
        <th>name</th>
        <th>img</th>
        <th>category</th>
        <th>price</th>
        <th>Qty</th>
        <th>Delete</th>
        <th>Update</th>
    </tr>
</thead>
<tbody>
     {listGame.map((x,i)=><tr key={i}>
        <td>{x.idgame}</td>
        <td>{x.game1}</td>
        <td><img src={`https://localhost:7032/${x.img}.jpg`} width={'30px'} ></img></td>
        <td>{x.idcategory}</td>
        <td>{x.price}</td>
        <td>{x.qty}</td>
        <td><Link to={`/game/dltGame/${x.idgame}`} className="btn btn-outline-black w-100 mb-2">🗑️</Link></td>
        <td><Link to="/game/UpdateGame" className="btn btn-outline-info w-100 mb-2">🔄</Link></td>
        </tr>)}
</tbody>     
</table>
<Link to="/game/AddGame" className="btn btn-outline-success w-100">Add Games</Link>
<Outlet></Outlet>
</>
}
