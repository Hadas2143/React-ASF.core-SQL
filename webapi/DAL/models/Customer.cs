using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class Customer
    {
        public Customer()
        {
            Shoppings = new HashSet<Shopping>();
        }

        public short Idcustomer { get; set; }
        public string? NameCustomer { get; set; }
        public string? Pass { get; set; }
        public string? CreditCard { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? Cvv { get; set; }

        public virtual ICollection<Shopping> Shoppings { get; set; }
    }
}
