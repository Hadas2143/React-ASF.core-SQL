import { useEffect, useState } from "react"
import { useParams } from "react-router-dom"
import { GetGameById } from "../axios/gameAxios"

export const Info=()=>{
    const url="https://localhost:7032/"
    let p=useParams()
    let [game,setGame]=useState(null)
    const doInfoGame=async()=>{
        if(game===null)
        {
           let y=(await GetGameById(p.x)).data
           setGame(y)
        }
    }
    useEffect(()=>{
      debugger
      doInfoGame()
    },[p.x])
    return <div>
       {game&&
        <div class="container mt-5">
        <div class="row justify-content-center">
          <div class="col-md-6 text-center">
            <img src={`${url}${game.img}.jpg`} class="img-fluid rounded mb-3" alt="Product Image"></img>
            <h3 class="fw-bold">{game.game1}</h3>
            <p class="text-muted">This is a detailed description of the product. It has all the information you need.</p>
            <p class="text-success fs-5">Price: {game.price}$</p>
            <br></br>
          </div>
        </div>
      </div>}
    </div> 
}