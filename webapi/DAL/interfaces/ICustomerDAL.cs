using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface ICustomerDAL
    {
        //get
        public List<Customer> GetAllCustemer();
        //delete
        public bool DeleteCustemer(int id);
        //upt
        public bool UpdateCustemer(Customer categoryTbl, int id);
        // add
        public bool AddCustemer(Customer categoryTbl);
        ////check
        //public bool IsCustomer(string name, string pass);
    }
}
