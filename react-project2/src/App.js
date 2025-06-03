import logo from './logo.svg';
import './App.css';
import { Nav } from './components/nav';
import { BrowserRouter, Routes } from 'react-router-dom';
import { Routing } from './components/routing';
import { useState } from 'react';
import { Provider } from './Context';

function App() {
  //context
  const [isManeger,setIsManeger]=useState(false)
  const [currUser,setCurrUser]=useState("no connect")
  const [passUser,setPassUser]=useState(0)
  const [cartR,setCartR]=useState([])
  const [isCart,setIsCart]=useState(false)
  const [sum,setSum]=useState(0)
  const [isConect,setIsConect]=useState(false)
  const [fromEnd,setFromEnd]=useState(false)
  const store={
    isManeger:isManeger,
    setIsManeger:setIsManeger,
    currUser:currUser,
    setCurrUser:setCurrUser,
    cartR:cartR,
    setCartR:setCartR,
    isCart:isCart,
    setIsCart:setIsCart,
    sum:sum,
    setSum:setSum,
    isConect:isConect,
    setIsConect:setIsConect,
    fromEnd:fromEnd,
    setFromEnd:setFromEnd,
    passUser:passUser,
    setPassUser:setPassUser
  }
  return (
    <div className="App">
      <Provider value={store}>
        <BrowserRouter>
          <Nav></Nav>
          <Routing></Routing>
        </BrowserRouter>
      </Provider>
    </div>
  );
}
export default App;