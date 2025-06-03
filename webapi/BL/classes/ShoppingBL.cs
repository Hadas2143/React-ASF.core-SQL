using AutoMapper;
using BL.interfaces;
using DAL.interfaces;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BL.classes
{
    public class ShoppingBL : IShoppingBL
    {
        IShoppingDAL s_DAL;
        IMapper mapper;
        public ShoppingBL( IShoppingDAL S_DAL)
        {
            this.s_DAL = S_DAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<ShoppingDTO> getShopping()  
        {
          return  mapper.Map<List<Shopping>,List<ShoppingDTO>>(s_DAL.GetAllShopping());
        }

        public int saveShopping(ShoppingDTO shop)
        {
            shop.DateBuy = DateTime.Now;
            Shopping s = mapper.Map<ShoppingDTO,Shopping>(shop);
            s_DAL.AddShopping(s);
            return s.Idbuy;
        }
    }
}
