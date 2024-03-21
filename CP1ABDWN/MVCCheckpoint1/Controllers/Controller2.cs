using Microsoft.AspNetCore.Mvc;

namespace MVCCheckpoint1.Controllers
{
    public class Controller2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
