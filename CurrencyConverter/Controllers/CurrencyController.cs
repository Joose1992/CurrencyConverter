using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyConverter.Models;
using CurrencyConverter.Services.Interfaces;
using CurrencyConverter.Services.Logic;
using CurrencyConverter.Services.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CurrencyConverter.Controllers
{
    public class CurrencyController : Controller
    {
        public readonly ICurrencyLogic _logic;

        public CurrencyController(ICurrencyLogic logic)
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
            CurrencyModel currency = new CurrencyModel
            {
                FromCurrency = model.FromCurrency,
                ToCurrency = model.ToCurrency,
                Amount = model.Amount
            };
            convertedAmount = _logic.ConvertCurrency(currency);
            double roundResult = Math.Round(convertedAmount, 2);
            model.ConvertedResult = roundResult;
                    
            
            return View("Index", model);
        }
    }
}

