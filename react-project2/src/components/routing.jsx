import { Route, Routes } from "react-router-dom"
import { Home } from "./home"
import { Login } from "./login"
import { Listing } from "./listing"
import { Cart } from "./cart"
import { Info } from "./info"
import { GameMang } from "./GameMang"
import { AddGame } from "./AddGame"
import { UpdateGame } from "./UpdateGame"
import { DeleteGame } from "./DeleteGame"
import { CategoryMang } from "./CategoryMang"
import { Addcategory } from "./Addcategory"
import { UpdateCategory } from "./UpdateCategory"
import { DeleteCategory } from "./DeleteCategory"
import { EndTotal } from "./endTotal"
import { MyAccount } from "./MyAccount"
import { ShopInfo } from "./shopInfo"
import { Pay } from "./Pay"
import { MyStore } from "./myStore"

export const Routing=()=>{
    return <div>
        <Routes>
            <Route path="/" element={<MyStore></MyStore>}></Route>
            <Route path="login" element={<Login></Login>}></Route>
            <Route path="home" element={<Home></Home>}>
                <Route path="info/:x/:y" element={<Info></Info>}></Route>
            </Route>
            <Route path="login" element={<Login></Login>}></Route>
            <Route path="listing" element={<Listing></Listing>}></Route>
            <Route path="cart" element={<Cart></Cart>}></Route>
            <Route path="game" element={<GameMang></GameMang>}>
                <Route path="AddGame" element={<AddGame></AddGame>}></Route>
                <Route path="UpdateGame" element={<UpdateGame></UpdateGame>}></Route>
                <Route path="dltGame/:id" element={<DeleteGame></DeleteGame>}></Route>
            </Route>
            <Route path="category" element={<CategoryMang></CategoryMang>}>
                <Route path="AddCtgy" element={<Addcategory></Addcategory>}></Route>
                <Route path="UpdateCtgy" element={<UpdateCategory></UpdateCategory>}></Route>
                <Route path="dltCtgy/:id" element={<DeleteCategory></DeleteCategory>}></Route>
            </Route>
            <Route path="endTotal/:x" element={<EndTotal></EndTotal>}></Route>
            <Route path="pay/:x" element={<Pay></Pay>}></Route>
            <Route path="myAccount" element={<MyAccount></MyAccount>}>
                <Route path="shopInfo/:x/:id" element={<ShopInfo></ShopInfo>}></Route>
            </Route>
        </Routes>
    </div>
}