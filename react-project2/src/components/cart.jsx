import { useContext } from "react"
import MyCotext from "../Context"
import { useNavigate } from "react-router-dom"

export const Cart=()=>{
    //import my context cart
    const setCart=useContext(MyCotext).setCartR
    const cart=useContext(MyCotext).cartR
    const isCart=useContext(MyCotext).isCart
    const setSum=useContext(MyCotext).setSum
    const sum=useContext(MyCotext).sum
    const setFromEnd=useContext(MyCotext).setFromEnd
    const isConect=useContext(MyCotext).isConect

    let myNevigate = useNavigate()

    const more=(x)=>{
        x.Qty++
        const updatedCart = cart.map(game =>
            game.Idgame === x.Idgame
              ? { ...game, Qty: x.Qty }
              : game
          );
          setCart(updatedCart);
          setSum(sum+x.PriceOfOne);
    }
    const less=(x)=>{
        x.Qty--
        if(x.Qty>0){
            const updatedCart = cart.map(game =>
                game.Idgame === x.Idgame
                ? { ...game, Qty: x.Qty }
                : game
            );
            setCart(updatedCart);
            }
        else{
            const updatedCart = cart.filter(item => item.Idgame !== x.Idgame);
            setCart(updatedCart);
        }
        setSum(sum-x.PriceOfOne);
    }
    const onClickFunc=()=>{
        setFromEnd(true)
        myNevigate('/login')
        // myNevigate('/pay')
    }
    return <>
    <table className="table">
    <thead>
        <tr>
            <th>IDgame</th>
            <th>Game</th>
            <th>Price</th>
            <th>Total Price</th>
            <th>Qty</th>
            <th>more</th>
            <th>less</th>
        </tr>
    </thead>
    <tbody>
     {cart.map((x,i)=><tr key={i}>
        <td>{x.Idgame}</td>
        <td>{x.Game1}</td>
        <td>{x.PriceOfOne}</td>
        <td>{x.PriceOfOne*x.Qty}</td>
        <td>{x.Qty}</td>
        <td><button onClick={()=>more(x)} className="btn btn-outline-light w-100 mb-2">➕</button></td>
        <td><button onClick={()=>less(x)} className="btn btn-outline-light w-100 mb-2">➖</button></td>
        </tr>)}
</tbody> 
</table>
{isCart&&
    <button onClick={()=>onClickFunc()} className="btn btn-outline-info w-25 mb-2">Pay</button>}
{isConect &&
    <p className="alert alert-info text-center fw-bold">The total price is: {sum}$</p>}

</>
}