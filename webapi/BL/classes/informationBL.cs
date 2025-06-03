using AutoMapper;
using BL.interfaces;
using DAL.classes;
using DAL.interfaces;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.classes
{
    public class informationBL : IinformationBL
    {
        IinformationDAL INFO;
        IMapper mapper;
        public informationBL(IinformationDAL info)
        {
            this.INFO = info;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myProfile>();
            });
            mapper = config.CreateMapper();
        }
        public bool AddInformation(informationDTO information)
        {
            Information info = mapper.Map<informationDTO, Information>(information);
            return INFO.AddInformation(info);
        }
        
        public bool DeleteInformation(int id)
        {
            return INFO.DeleteInformation(id);
        }

        public List<informationDTO> GetAllInformation()
        {
            return mapper.Map<List<Information>, List<informationDTO>>(INFO.GetAllInformation());
        }

        public List<informationDTO> GetInformationByID(int idBuy)
        {
            List<informationDTO> l=GetAllInformation();
            List<informationDTO> myL=new List<informationDTO>();
            for(int i =0;i<l.Count();i++)
            {
                if (l[i].Idbuy == idBuy)
                    myL.Add(l[i]);
            }
            return myL;
        }
        public bool UpdateInformation(informationDTO information, int id)
        {
            Information info = mapper.Map<informationDTO, Information>(information);
            return INFO.UpdateInformation(info, id);
        }

        public bool SaveBuyInInformation(int id, List<CartDTO> sal)
        {
            try
            {
                foreach (var item in sal)
                {
                    Information info = new();
                    info.Idbuy = id;
                    info.Idgame = item.Idgame;
                    info.QtyOfInfo = item.Qty;
                    INFO.AddInformation(info);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

       
    }
}
