using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ShoppingDTO    
    {
        public int Idbuy { get; set; }
        public short? Idcustomer { get; set; }
        public DateTime? DateBuy { get; set; }
        public int? Price { get; set; }
    }
}
