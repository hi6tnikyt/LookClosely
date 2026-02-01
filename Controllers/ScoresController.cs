using LookClosely.Data;
using LookClosely.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LookClosely.Controllers
{
    public class ScoresController : Controller
    {
        private readonly HiddenGameDbContext dbContext;

        public ScoresController(HiddenGameDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Save(int userId, int levelId, int points)
        {
            dbContext.Scores.Add(new Score
            {
                UserId = userId,
                LevelId = levelId,
                Points = points
            });

            dbContext.SaveChanges();
            return Ok();
        }

        public IActionResult Leaderboard()
        {
            var leaderboard = dbContext.Scores
                .Include(s => s.User)
                .OrderByDescending(s => s.Points)
                .Take(50)
                .ToList();

            return View(leaderboard);
        }
    }
}