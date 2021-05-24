﻿using Microsoft.AspNetCore.Mvc;
using Numeru.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Numeru.Web.Controllers
{
    public class MomentController: Controller
    {
        private readonly IDigitService _digit;

        public MomentController(IDigitService digit)
        {
            this._digit = digit;
        }

        public async Task<ActionResult> Index()
        {
            await Task.Yield();

            var date = DateTime.Now;
            var number = this._digit.Digit(date);

            var vm = new MomentIndexViewModel
            {
                Number = number,
                Description = "Кармическое число - благоприятный знак.",
                Date = date,
                Prediction = "Если проявите внимательность, то разглядите большую любовь совсем близко от себя.",
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
