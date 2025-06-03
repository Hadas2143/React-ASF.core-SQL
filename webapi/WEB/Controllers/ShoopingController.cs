using BL.interfaces;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoopingController : ControllerBase
    {
        IShoppingBL s_bl;
        public ShoopingController(IShoppingBL bl)
        {
            s_bl = bl;
        }
        [HttpPut("SaveInShop")]
        public int SaveInShop(ShoppingDTO shop)
        {
            return s_bl.saveShopping(shop);
        }
        [HttpGet("getAllShopping")]
        public List<ShoppingDTO> GetAll()
        {
            return s_bl.getShopping();  
        }
    }
}
