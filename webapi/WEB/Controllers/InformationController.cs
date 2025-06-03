using BL.classes;
using BL.interfaces;
using DAL.models;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        IinformationBL i_bl;
        public InformationController(IinformationBL i_bl)
        {
            this.i_bl = i_bl;
        }
        [HttpGet("getInfo")]
        public List<informationDTO> Get()
        {
            return i_bl.GetAllInformation();
        }
        [HttpPut("AddInfo")]
        public bool add(informationDTO informationDTO)
        {
            return i_bl.AddInformation(informationDTO);
        }
        [HttpPost("uptInfo/{id}")]
        public bool update(informationDTO informationDTO, int id)
        {
            return i_bl.UpdateInformation(informationDTO, id);
        }
        [HttpDelete("deleteInfo/{id}")]
        public bool delete(int id)
        {
            return i_bl.DeleteInformation(id);
        }
        [HttpPut("SaveInIformation/{id}")]
        public bool SaveInIformation(int id,List<CartDTO> sal)
        {
            return i_bl.SaveBuyInInformation(id, sal);
        }
        [HttpGet("GetInfoByID/{id}")]
        public List<informationDTO> GetInformationByID(int id)
        {
           return i_bl.GetInformationByID(id);
        }
    }
}
