using Microsoft.AspNetCore.Mvc;

namespace LookClosely.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
