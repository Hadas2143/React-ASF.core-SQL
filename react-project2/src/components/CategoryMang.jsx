import { useEffect, useState } from "react"
import { GetAllCategoryR } from "../axios/categoryAxios"
import { Link, Outlet } from "react-router-dom"

export const CategoryMang=()=>{
    debugger
    //for intreduce a category in table
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
    return <>
     <table className="table">
<thead>
    <tr>
        <th>id</th>
        <th>name</th>
        <th>Delete</th>
        <th>Update</th>
    </tr>
</thead>
<tbody>
     {categoryList.map((x,i)=><tr key={i}>
        <td>{x.idcategory}</td>
        <td>{x.nameCategory}</td>
        <td><Link to={`/category/dltCtgy/${x.idcategory}`} className="btn btn-outline-black w-100 mb-2">🗑️</Link></td>
        <td><Link to="/category/UpdateCtgy" className="btn btn-outline-info w-100 mb-2">🔄</Link></td>
        </tr>)}
</tbody>     
</table>
<Link to="/category/AddCtgy" className="btn btn-outline-success w-100">Add Category</Link>
<Outlet></Outlet>
</>
}