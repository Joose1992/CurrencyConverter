using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyConverter.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CurrencyConverter.Controllers
{
    public class CurrencyController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            CurrencyViewModel model = new CurrencyViewModel();
            return View(model);
        }

        public IActionResult Convert(CurrencyViewModel model)
        {
            return View();
        }
    }
}

