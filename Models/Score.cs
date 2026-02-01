using System.ComponentModel.DataAnnotations;

namespace LookClosely.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }

        public int Points { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;

        public int UserId { get; set; }

        public User User { get; set; } = null!;

        public int LevelId { get; set; }

        public Level Level { get; set; } = null!;
    }
}
