using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class Controler1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
