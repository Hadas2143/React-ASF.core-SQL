using AutoMapper;
using BL.interfaces;
using DAL.interfaces;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.classes
{
    public class CustomerBL : IcustomerBL
    {
        ICustomerDAL c_DAL;
        IMapper mapper;

        public CustomerBL(ICustomerDAL c_DAL)
        {
            this.c_DAL = c_DAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myProfile>();
            });
            mapper = config.CreateMapper();
        }

        public bool AddCustomer(CustomerDTO customer)
        {
            Customer c=mapper.Map<CustomerDTO,Customer>(customer);
            return c_DAL.AddCustemer(c);
        }
        public bool CheckCustomer(string name, string? pass)
        {
            List<Customer> L = c_DAL.GetAllCustemer();
            foreach (Customer c in L)
            {
                if (c.NameCustomer.Equals(name) && c.Pass.Equals(pass))
                    return true;
            }
            return false;
        }

        public bool DeleteCustomer(int id)
        {
            return c_DAL.DeleteCustemer(id);
        }

        public List<CustomerDTO> GetAllCustomers()
        {
            return mapper.Map<List<Customer>, List<CustomerDTO>>(c_DAL.GetAllCustemer());
        }

        public bool UpdateCustomer(CustomerDTO customer, int id)
        {
            Customer c = mapper.Map<CustomerDTO, Customer>(customer);
            return c_DAL.UpdateCustemer(c, id);
        }
        public int GetIDCustomerByPass(string pass) 
        {
            List<Customer> L = c_DAL.GetAllCustemer();
            foreach (Customer c in L)
            {
                if(c.Pass.Equals(pass))
                    return c.Idcustomer;
            }
            return 0;
        }
    }
}
