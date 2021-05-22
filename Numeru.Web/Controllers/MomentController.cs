using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
                Number = 11,
                Date = DateTime.Now,
                Prediction = "Если проявите внимательность, то разглядите большую любовь совсем близко от себя.",
                DominantNumber = true,
                KarmicNumber = true,
                Calculation = new List<string>()
                {
                    "2 + 0 + 0 + 5 + 2 + 0 + 2 + 1 + 1",
                    "+",
                    "1 + 0 + 4 + 6 + 1 + 8",
                    "=",
                    "32 → 3 + 2 = 5"
                },
                CalculationRemark = new List<string>()
                {
                    "Дата",
                    "+",
                    "Время"
                }
            };

            return View(vm);
        }
    }
}
