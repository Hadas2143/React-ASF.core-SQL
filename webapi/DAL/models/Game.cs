using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class Game
    {
        public Game()
        {
            Information = new HashSet<Information>();
        }

        public short Idgame { get; set; }
        public string? Game1 { get; set; }
        public short? Idcategory { get; set; }
        public short? Price { get; set; }
        public string? Img { get; set; }
        public int? Qty { get; set; }

        public virtual CategoryTbl? IdcategoryNavigation { get; set; }
        public virtual ICollection<Information> Information { get; set; }
    }
}
