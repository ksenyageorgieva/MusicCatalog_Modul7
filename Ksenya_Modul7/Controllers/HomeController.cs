using Microsoft.AspNetCore.Mvc;

namespace MusicCatalog.Controllers
{

    public class HomeController : Controller
        {
        public ActionResult Index()
            {
                var model = new HomeViewModel
                {
                    WelcomeMessage = "Hello, welcome to our site!",
                    ApplicationName = "My Application"
                };
            return View(model);
            }
        }
}