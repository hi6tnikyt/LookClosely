using System.ComponentModel.DataAnnotations;

namespace LookClosely.Models
{
    public class Level
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string ImagePath { get; set; } = null!;

        public ICollection<Score> Scores { get; set; }
              = new List<Score>();
    }
}
