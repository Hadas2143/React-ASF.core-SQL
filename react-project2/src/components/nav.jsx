import { Link } from "react-router-dom"
import MyCotext from "../Context"
import { useContext } from "react"

export const Nav=()=>{
  //removable from a context member
  const isManeger=useContext(MyCotext).isManeger
  const currUser=useContext(MyCotext).currUser
  const isConect=useContext(MyCotext).isConect
  const setIsConect=useContext(MyCotext).setIsConect
  if (currUser !== "no connect")
    setIsConect(true)
    return <>
  <ul className="nav nav-underline">
  <li className="nav-item">
    <Link className="nav-link"  to={'home'}>Home</Link>
  </li>
  <li className="nav-item">
    <Link className="nav-link"  to={'home'}>Home</Link>
  </li>
  <li className="nav-item">
    <Link className="nav-link" to={'login'}>Login</Link>
  </li>
  <li className="nav-item">
    <Link className="nav-link" to={'listing'}>listing</Link>
  </li>
  <li className="nav-item">
    <Link className="nav-link" to={'cart'}>Cart</Link>
  </li>
{ isManeger&&
 <li className="nav-item">
    <Link className="nav-link" to={'game'}>Games</Link>
  </li>
  }
  { isManeger&&
 <li className="nav-item">
    <Link className="nav-link" to={'category'}>Category</Link>
  </li>
  }
  { isConect &&
 <li className="nav-item">
    <Link className="nav-link" to={'myAccount'}>My Account</Link>
  </li>
  }
  <li className="nav-item">
    <p className="nav-link"> hello {currUser}</p>
  </li>
</ul>
 </>
}