using LookClosely.Data;
using LookClosely.Models;
using Microsoft.AspNetCore.Mvc;

namespace LookClosely.Controllers
{
    public class AccountController : Controller
    {
        private readonly HiddenGameDbContext dbContext;

        public AccountController(HiddenGameDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Login() => View();
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            if (dbContext.Users.Any(u => u.Username == username))
            {
                ViewBag.Error = "User already exists";
                return View();
            }

            dbContext.Users.Add(new User
            {
                Username = username,
                Password = password
            });

            dbContext.SaveChanges();
            return RedirectToAction(nameof(Login));
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = dbContext.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                ViewBag.Error = "Invalid login";
                return View();
            }
            HttpContext.Session.SetInt32("UserId", user.Id);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Login));
        }
    }
}