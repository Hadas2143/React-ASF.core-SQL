using BL.interfaces;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        IcustomerBL C_bl;
        public CustomerController(IcustomerBL c_bl)
        {
            this.C_bl = c_bl;
        }
        [HttpGet("getCustomer")]
        public List<CustomerDTO> get()
        {
            return C_bl.GetAllCustomers();
        }
        [HttpDelete("deleteCustomer/{id}")]
        public bool delete(int id)
        {
            return C_bl.DeleteCustomer(id);
        }
        [HttpPost("updateCustomer/{id}")]
        public bool upt(CustomerDTO c, int id)
        {
            return C_bl.UpdateCustomer(c, id);
        }
        [HttpPut("addCustomer")]
        public bool add(CustomerDTO c)
        {
            return C_bl.AddCustomer(c);
        }
        [HttpGet("checkCustomer/{name}/{pass}")]
        public bool check(string name, string? pass)
        {
            return C_bl.CheckCustomer(name, pass);
        }
        [HttpGet("GetIDCustomerByPass/{pass}")]
        public int get(string pass)
        {
            return C_bl.GetIDCustomerByPass(pass);
        }
    }
}
