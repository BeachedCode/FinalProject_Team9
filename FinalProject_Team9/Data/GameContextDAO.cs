using FinalProject_Team9.Models;
using ContemporaryProgrammingFinal.Models;
using FinalProject_Team9.Data;

namespace ContemporaryProgrammingFinal.Data
{
    public class GameContextDAO : IGamesContextDAO
    {
        private TeamContext _context;
        public GameContextDAO(TeamInfoContext context) 
        {
            _context= context;
        }

        public int? AddGame(Game game)
        {
            var games = _context.Games.Where(x => x.Name!.Equals(game.Name)).FirstOrDefault();
            if (games != null)
            {
                return null;
            }
            try
            {
                _context.Games.Add(game);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
            
        }

        public List<Game> GetAllGames()
        {
            return _context.Games.ToList();
        }
        public List<Game> GetFirstFive() 
        {
            return _context.Games.Take(5).ToList();
        }

       public Game GetGame(int id)
        {
            return _context.Games.Where(x => x.Id.Equals(id)).FirstOrDefault()!;
        }

        public int? RemoveGame(int id)
        {
            var game = this.GetGame(id);
            if (game == null) return null;
            try
            {
                _context.Games.Remove(game);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }

        public int? UpdateGame(Game game)
        {
            var gameToUpdate = this.GetGame(game.Id);
            if (gameToUpdate == null) return null;

            gameToUpdate.Name= game.Name;
            gameToUpdate.ReleaseYear= game.ReleaseYear;
            gameToUpdate.GameCategory = game.GameCategory;
            gameToUpdate.PlayerMinimum = game.PlayerMinimum;
            gameToUpdate.PlayerMaximum = game.PlayerMaximum;
            gameToUpdate.PlayTime= game.PlayTime;
            gameToUpdate.PlayerAges = game.PlayerAges;

            try
            {
                _context.Games.Update(gameToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }
    }
}
