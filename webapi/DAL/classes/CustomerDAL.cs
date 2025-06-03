using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.classes
{
    public class CustomerDAL: ICustomerDAL
    {
        Game_storeContext DB = new();

        public bool AddCustemer(Customer c)
        {
            try
            {
                DB.Customers.Add(c);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustemer(int id)
        {
            try
            {
                Customer Ct = DB.Customers.FirstOrDefault(x => x.Idcustomer == id);
                DB.Customers.Remove(Ct);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customer> GetAllCustemer()
        {
            return DB.Customers.Include(j => j.Shoppings).ToList();
        }

        //public bool IsCustomer(string name, string pass)
        //{
        //    List<Customer> L = GetAllCustemer();
        //    foreach (Customer c in L)
        //    {
        //        if (c.NameCustomer.Equals(name) && c.Idcustomer.Equals(pass))
        //            return true;
        //    }
        //    return false;
        //}

        public bool UpdateCustemer(Customer categoryTbl, int id)
        {
            try
            {
                Customer Ct = DB.Customers.FirstOrDefault(x => x.Idcustomer == id);
                DB.Entry(Ct).CurrentValues.SetValues(categoryTbl);
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
