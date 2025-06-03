using AutoMapper;
using BL.interfaces;
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
    public class GameBL : IGameBL
    {
        IGameDAL G;
        IMapper mapper;

        public GameBL(IGameDAL g)
        {
            this.G = g;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myProfile>();
            });
            mapper = config.CreateMapper();
        }
        public bool AddGame(GameDTO game)
        {
            Game c = mapper.Map<GameDTO, Game>(game);
            Console.WriteLine("in bl");
            return G.AddGame(c);
        }

        public bool DeleteGame(int id)
        {
            return G.DeleteGame(id);    
        }

        public List<GameDTO> GetAllGame()
        {
            return mapper.Map<List<Game>, List<GameDTO>>(G.GetAllGame());
        }

        public GameDTO getById(int id)
        {
            List<GameDTO> l = GetAllGame();
            return l.FirstOrDefault(x => x.Idgame == id);
        }

        public List<GameDTO> GetGamesByCategory(int IDcategory)
        {
            List<GameDTO> l = GetAllGame();
            return l.Where(x => x.Idcategory == IDcategory).ToList();
        }

        public bool UpdateGame(GameDTO game, int id)
        {
            Game g=mapper.Map<GameDTO, Game>(game);
            return G.UpdateGame(g, id);
        }

        public bool uptQty(List<CartDTO> sal)
        {
            try
            {
                foreach (CartDTO cart in sal) {
                    Game g = new();
                    g=mapper.Map<GameDTO,Game>(getById(cart.Idgame));
                    g.Qty= g.Qty-cart.Qty;
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
