using AutoMapper;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class myProfile:Profile
    {
        public myProfile()
        {
            //CategoryTbl
            CreateMap<CategoryTbl, CategoryDTO>();
            CreateMap<CategoryDTO ,CategoryTbl>();
            //Customer
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();
            //Game
            CreateMap<Game, GameDTO>();
            CreateMap<GameDTO, Game>();
            //information
            CreateMap<Information, informationDTO>();
            CreateMap<informationDTO, Information>();
            //shopping
            CreateMap<Shopping, ShoppingDTO>();
            CreateMap<ShoppingDTO, Shopping>();
            //cart no imlements becouse it isn't have a place in sql


        }
    }
}
