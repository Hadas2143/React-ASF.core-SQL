using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.interfaces
{
    public interface IShoppingBL
    {
        // strep num 1:
        //save buyid
        public int saveShopping(ShoppingDTO shop);
       
        //getAll
        public List<ShoppingDTO> getShopping(); 
    }
}
