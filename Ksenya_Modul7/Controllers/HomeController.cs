using Microsoft.AspNetCore.Mvc;

namespace MusicCatalog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
