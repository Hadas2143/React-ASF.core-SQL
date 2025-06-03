using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.interfaces
{
    public interface IinformationBL
    {
        //get
        public List<informationDTO> GetAllInformation();
        //delete
        public bool DeleteInformation(int id);
        //upt
        public bool UpdateInformation(informationDTO information, int id);
        // add
        public bool AddInformation(informationDTO information);

        //save in inforation 
        public bool  SaveBuyInInformation(int id,List<CartDTO> sal);
        // get buys by idbuy
        public List<informationDTO> GetInformationByID(int idBuy);   


    }
}
