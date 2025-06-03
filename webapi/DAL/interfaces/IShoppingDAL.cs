using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IShoppingDAL
    {
        //get       
        public List<Shopping> GetAllShopping();
        //delete
        public bool DeleteShopping(int id);
        //upt
        public bool UpdateShopping(Shopping Shopping, int id);
        // add
        public bool AddShopping(Shopping Shopping);

    }
}
