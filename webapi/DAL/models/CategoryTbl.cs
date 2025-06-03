using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class CategoryTbl
    {
        public CategoryTbl()
        {
            Games = new HashSet<Game>();
        }

        public short Idcategory { get; set; }
        public string? NameCategory { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
