using DAL.models;
using DTO;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.interfaces
{
    public interface IcustomerBL
    {
        //get
        public List<CustomerDTO> GetAllCustomers();
        //delete
        public bool DeleteCustomer(int id);
        //upt
        public bool UpdateCustomer(CustomerDTO customer, int id);
        //add
        public bool AddCustomer(CustomerDTO customer);
        //check
        public bool CheckCustomer(string name, string? pass);
        //get id customer by password
        public int GetIDCustomerByPass(string pass);    
    }
}
