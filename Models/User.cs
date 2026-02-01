using System.ComponentModel.DataAnnotations;

namespace LookClosely.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        public ICollection<Score> Scores { get; set; }
              = new List<Score>();
    }
}
