using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        public short Idcustomer { get; set; }
        public string? NameCustomer { get; set; }
        public string? Pass { get; set; }
        public string? CreditCard { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? Cvv { get; set; }
    }
}
