using Microsoft.AspNetCore.Mvc;

namespace Numeru.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Moment");
        }
    }
}
