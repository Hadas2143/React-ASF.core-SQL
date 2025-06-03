using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IGameDAL
    {
        //get
        public List<Game> GetAllGame();
        //delete
        public bool DeleteGame(int id);
        //upt
        public bool UpdateGame(Game game, int id);
        // add
        public bool AddGame(Game game); 
        ////getById
        //public Game getById(int id);
        ////GetGamesByCategory
        //public List<Game> GetGamesByCategory(int IDcategory);     
    }
}
