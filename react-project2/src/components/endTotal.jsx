import { useNavigate, useParams } from "react-router-dom";
import { SaveInShopR } from "../axios/ShoopingAxios";
import { useContext, useEffect, useRef } from "react";
import MyCotext from "../Context";
import { GetAllCustomerR } from "../axios/customerAxios";
import { SaveInIformationR } from "../axios/informationAxios";
import { UptQty } from "../axios/gameAxios";

export const EndTotal = () => {
    let params = useParams();

    const sum = useContext(MyCotext).sum;
    const cart = useContext(MyCotext).cartR;
    const setFromEnd = useContext(MyCotext).setFromEnd;
    const setCartR = useContext(MyCotext).setCartR;

    const myShooping = {
        "Idbuy": 0,
        "Idcustomer": 0,
        "DateBuy": new Date().toISOString(),
        "Price": sum
    };

    const hasRun = useRef(false); // for useEffect
    const SaveObj = async () => {
        setFromEnd(false);
        let arr = (await GetAllCustomerR()).data;
        console.log(arr);
        for (let i = 0; i < arr.length; i++) {
            if (arr[i].pass === params.x) {
                myShooping.Idcustomer = arr[i].idcustomer;
            }
        }
        console.log(myShooping.Idcustomer);
        endTotalfunc();
        
    };

    useEffect(() => {
        if (!hasRun.current) {
            hasRun.current = true; //for work only 1 time
            SaveObj();
        }
    }, []); 

    let s1, s2, s3;

    const endTotalfunc = () => {
        endTotalfunc1();
    };

    const endTotalfunc1 = async () => {
        try {
            s1 = (await SaveInShopR(myShooping)).data;
            console.log(s1);
            if (s1) {
                s2 = (await SaveInIformationR(s1, cart)).data;
                console.log(s2);
                if (s2) {
                    s3 = (await UptQty(cart)).data;
                    console.log(s3);
                    if (s3) {
                        alert("Your buying was successful.");
                        setCartR([]);
                    }
                }
            }
        } catch (error) {
            console.error("Error in endTotalfunc1:", error);
        }
    };

    return <>
    <h1>Your purchase was successful.</h1>
    <h2>sum:{sum}</h2>
    </>
};
