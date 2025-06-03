import { useEffect, useState } from "react"
import { useParams } from "react-router-dom"
import { GetAllInformationR } from "../axios/informationAxios"

export const ShopInfo=()=>{
    let params=useParams()
    console.log(params.id)
    const [arrInfo,setArrInfo]=useState([])
    const [arrMyInfo,setArrMyInfo]=useState([])
    const func=async()=>{
        let arrHelp=(await GetAllInformationR()).data
        console.log(arrHelp)
        setArrInfo(arrHelp);
        console.log("info:",arrInfo)
    }
    useEffect(()=>{
        func()
    },[])
    useEffect(() => {
        const find = () => {
          const arr = arrInfo.filter((item) => item.idbuy == params.id);
          setArrMyInfo(arr);
          console.log("Filtered Data:", arr);
        };
        if (arrInfo.length > 0) {
          find();
        }
      }, [arrInfo]); //wait to arrInfo
 return (
        <div>
          <h3>My Information:</h3>
          <ul className="list-group">
            {arrMyInfo.map((item,i) => (
              <li key={i} className="list-group-item">
                ID buy: {item.idbuy}, Shopping: {item.idNumOfShooping}, IDgame: {item.idgame}, Qty: {item.qtyOfInfo}
              </li>
            ))}
          </ul>
        </div>
      );
}