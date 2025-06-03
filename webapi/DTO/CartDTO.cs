using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CartDTO
    {
        public virtual short Idgame { get; set; }
        public virtual string? Game1 { get; set; }
        public int Qty {  get; set; }
        public short? PriceOfOne { get; set; }
        public short? FinalPrice { get; set; }
            
    }
}
