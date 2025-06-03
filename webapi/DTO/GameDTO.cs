using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GameDTO
    {
        public short Idgame { get; set; }
        public string? Game1 { get; set; }
        public short? Idcategory { get; set; }
        public short? Price { get; set; }
        public string? Img { get; set; }
        public int? Qty { get; set; }
        //localhoost for pic
        //public string? pic { get; set; }
    }
}
