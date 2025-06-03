using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.interfaces
{
    public interface IGameBL
    {
        //get
        public List<GameDTO> GetAllGame();
        //delete
        public bool DeleteGame(int id);
        //upt
        public bool UpdateGame(GameDTO game, int id);
        // add
        public bool AddGame(GameDTO game);
        //getById
        public GameDTO getById(int id);
        //GetGamesByCategory
        public List<GameDTO> GetGamesByCategory(int IDcategory);  
        //uptade of qty
        public bool uptQty(List<CartDTO> sal);
    }
}
