import { Link, useParams } from "react-router-dom"

export const Pay=()=>{
    let p=useParams()
    return <>
    <input className="form-control" type="txt" placeholder="customer name"/>
    <br></br>
    <input className="form-control" type="txt" placeholder="munber credit card"/>
    <br></br>
    <input className="form-control" type="date" placeholder="expiration Date" />
    <br></br>
    <input className="form-control" type="txt" placeholder="cvv" />
    <br></br>
    <Link to={`/endTotal/${p.x}`} className="btn btn-info">OK</Link>
    </>
}