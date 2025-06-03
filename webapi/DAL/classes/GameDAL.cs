using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.classes
{
    public class GameDAL : IGameDAL
    {
        Game_storeContext DB = new();
        public bool AddGame(Game game)
        {
            try
            {
                DB.Games.Add(game);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGame(int id)
        {
            try
            {
                Game Ct = DB.Games.FirstOrDefault(x => x.Idgame == id);
                DB.Games.Remove(Ct);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Game> GetAllGame()
        {
            return DB.Games.Include(j => j.Information).ToList();
        }

        //public Game getById(int id)
        //{
        //    return DB.Games.FirstOrDefault(x => x.Idgame == id);
        //}

        //public List<Game> GetGamesByCategory(int IDcategory)
        //{
        //    return DB.Games.Where(x=>x.Idcategory == IDcategory).ToList();
        //}

        public bool UpdateGame(Game game, int id)
        {
            try
            {
                Game Ct = DB.Games.FirstOrDefault(x => x.Idgame ==id);
                DB.Entry(Ct).CurrentValues.SetValues(game);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
