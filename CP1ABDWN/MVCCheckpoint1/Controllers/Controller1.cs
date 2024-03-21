using Microsoft.AspNetCore.Mvc;

namespace MVCCheckpoint1.Controllers
{
    public class Controller1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
