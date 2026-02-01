using Microsoft.AspNetCore.Mvc;

namespace LookClosely.Controllers
{
    public class LevelsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
