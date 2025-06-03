using BL.interfaces;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        IGameBL g_bl;
        public GameController(IGameBL g_bl)
        {
            this.g_bl = g_bl;
        }
        [HttpGet("getGame")]
        public List<GameDTO> GetGames()
        {
            return g_bl.GetAllGame();
        }
        [HttpPost("updateGame/{id}")]
        public bool upt(GameDTO game,int id)
        {
            return g_bl.UpdateGame(game,id);
        }
        [HttpPut("addGame")]
        public bool Add(GameDTO game)
        {
            Console.WriteLine(  "in control");
            return g_bl.AddGame(game);
        }
        [HttpDelete("deleteGame/{id}")]
        public bool Delete(int id)
        {
            return g_bl.DeleteGame(id);
        }
        [HttpGet("getById/{id}")]
        public GameDTO GetGameById(int id)
        {
            return g_bl.getById(id);
        }
        [HttpGet("getByCtegory/{IdC}")]
        public List<GameDTO> GetByCtegory(int IdC)
        {
            return g_bl.GetGamesByCategory(IdC);
        }
        [HttpPost("uptMyQty")]
        public bool UpdateGame(List<CartDTO> sal)
        {
            return g_bl.uptQty(sal);
        }
    }
}
