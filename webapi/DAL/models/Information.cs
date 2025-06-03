using System;
using System.Collections.Generic;

namespace DAL.models
{
    public partial class Information
    {
        public int IdNumOfShooping { get; set; }
        public int? Idbuy { get; set; }
        public short? Idgame { get; set; }
        public int? QtyOfInfo { get; set; }
        public virtual Shopping? IdbuyNavigation { get; set; }
        public virtual Game? IdgameNavigation { get; set; }
    }
}
