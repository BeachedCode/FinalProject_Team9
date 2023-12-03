using System.ComponentModel.DataAnnotations;

namespace ContemporaryProgrammingFinal.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ReleaseYear { get; set; }
        public string? GameCategory { get; set;}
        public int PlayerMinimum { get; set; }
        public int PlayerMaximum { get; set; }
        public string? PlayTime { get; set; }
        public string? PlayerAges { get; set; }
    }
}
