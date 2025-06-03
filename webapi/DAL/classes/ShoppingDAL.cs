using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.classes
{
    public class ShoppingDAL : IShoppingDAL
    {
        Game_storeContext DB = new();
        public bool AddShopping(Shopping Shopping)
        {
            try
            {
                DB.Shoppings.Add(Shopping);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteShopping(int id)
        {
            try
            {
                Shopping Ct = DB.Shoppings.FirstOrDefault(x => x.Idbuy == id);
                DB.Shoppings.Remove(Ct);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Shopping> GetAllShopping()  
        {
            return DB.Shoppings.ToList();
        }

        public bool UpdateShopping(Shopping Shopping, int id)
        {
            try
            {
                Shopping Ct = DB.Shoppings.FirstOrDefault(x => x.Idbuy == id);
                DB.Entry(Ct).CurrentValues.SetValues(Shopping);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
