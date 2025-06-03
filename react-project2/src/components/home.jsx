import { useContext, useEffect, useState } from "react"
import { GetAllGame } from "../axios/gameAxios"
import { Link, Outlet, useNavigate } from "react-router-dom"
import MyCotext from "../Context"

export const Home=()=>{
    //import my context cart
    const setCart=useContext(MyCotext).setCartR
    const cart=useContext(MyCotext).cartR
    const setIsCart=useContext(MyCotext).setIsCart
    const setSum=useContext(MyCotext).setSum
    const sum=useContext(MyCotext).sum

    //present all prodacts
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
    const url="https://localhost:7032/"
    //add to cart
    let gameToAdd={
      "Idgame":0,
      "Game1":"",
      "Qty":0,
      "PriceOfOne":0,
      "FinalPrice":0
    }
    const addToCart=(g)=>{
      let x=cart.some(item =>item.Idgame===g.idgame)
      if(!x)
        {
          setIsCart(true)
          gameToAdd.Idgame=g.idgame
          gameToAdd.Game1=g.game1
          gameToAdd.Qty=1
          gameToAdd.PriceOfOne=g.price
          setSum(sum+gameToAdd.PriceOfOne);
          gameToAdd.FinalPrice=sum
          setCart([...cart,gameToAdd])
        }
        else{
          alert("it is in cart")
        }
        
    }
    return <div className="container">
    <div className="row g-3"> 
    {listGame.map((x, i) => (
      <div key={i} className="col-sm-6 col-md-4 col-lg-3">
        <div className="card h-100 shadow-sm" style={{ width: "100%" }}>
          <div className="card-body d-flex flex-column justify-content-between">
            <h4 className="card-title">{x.game1}</h4>
            <p className="card-text">Price: {x.price}$</p>
            <div>
              <Link to={`info/${x.idgame}/${x.img}`} className="btn btn-outline-info w-100 mb-2">Information</Link>
              <button onClick={()=>addToCart(x)} className="btn btn-outline-success w-100">Add to cart</button>
            </div>
          </div>
        </div>
      </div>
    ))}
  </div>
  <Outlet></Outlet>
</div>
}

