using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Numeru.Web.Controllers
{
    public class MomentController: Controller
    {
        public async Task<ActionResult> Index()
        {
            await Task.Yield();

            var vm = new MomentIndexViewModel
            {
                Number = 11
            };

            return View(vm);
        }
    }
}
