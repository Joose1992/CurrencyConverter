using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyConverter.Models;
using CurrencyConverter.Services.Logic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CurrencyConverter.Controllers
{
    public class CurrencyController : Controller
    {
        public readonly CurrencyLogic _logic;

        public CurrencyController(CurrencyLogic logic)
        {
            _logic = logic;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            CurrencyViewModel model = new CurrencyViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Convert(CurrencyViewModel model)
        {
            double convertedAmount = 0.0;
                    
            
            return View();
        }
    }
}

