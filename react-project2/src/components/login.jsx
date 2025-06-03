import { useContext, useState } from "react"
import MyCotext from "../Context"
import { CheckCustomerR } from "../axios/customerAxios"
import { useNavigate } from "react-router-dom"

export const Login=()=>{
    const[user,setUser]=useState("")
    //removable from a context member
    const setIsManeger=useContext(MyCotext).setIsManeger
    const setCurrUser=useContext(MyCotext).setCurrUser
    const fromEnd=useContext(MyCotext).fromEnd
    const setPassUser=useContext(MyCotext).setPassUser

    let myNevigate = useNavigate()

    const Check=async()=>{
        if (!user.name || !user.pass) {
            alert("Please enter name and password");
            return;
        }
        else if(user.name==='m'&&user.pass==1)
        {
            setIsManeger(true)
            setCurrUser('m')
            return;
        }
        else {
            setIsManeger(false)
            let x = (await CheckCustomerR(user.name, user.pass)).data
            if (!x) {
                myNevigate('/listing')
            }
            else {
                setCurrUser(user.name)
                setPassUser(user.pass)
                if(fromEnd)
                    myNevigate(`/pay/${user.pass}`)
            }
        }
    }
    return (
        <div className="container d-flex justify-content-center mt-5">
          <div className="card shadow" style={{ width: "400px" }}>
            <div className="card-body">
              <h3 className="card-title text-center mb-4">Login</h3>
              <div className="mb-3">
                <label className="form-label" htmlFor="username">
                  Username
                </label>
                <input
                  id="username"
                  className="form-control"
                  type="text"
                  placeholder="Enter your username"
                  onBlur={(e)=>setUser({...user,name:e.target.value})}
                />
              </div>
              <div className="mb-3">
                <label className="form-label" htmlFor="password">
                  Password
                </label>
                <input
                  id="password"
                  className="form-control"
                  type="password"
                  placeholder="Enter your password"
                  onBlur={(e)=>setUser({...user,pass:e.target.value})}
                />
              </div>
              <button
                className="btn btn-outline-primary w-100 mb-2"
                onClick={() => Check()}
              >
                Login
              </button>
            </div>
          </div>
        </div>
      )
}