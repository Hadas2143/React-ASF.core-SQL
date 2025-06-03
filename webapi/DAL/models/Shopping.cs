using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class Shopping
    {
        public Shopping()
        {
            Information = new HashSet<Information>();
        }

        public int Idbuy { get; set; }
        public short? Idcustomer { get; set; }
        public DateTime? DateBuy { get; set; }
        public int? Price { get; set; }

        public virtual Customer? IdcustomerNavigation { get; set; }
        public virtual ICollection<Information> Information { get; set; }
    }
}
