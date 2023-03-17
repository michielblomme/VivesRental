using Microsoft.AspNetCore.Mvc;

namespace VivesRental.Ui.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
