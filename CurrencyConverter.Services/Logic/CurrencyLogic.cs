using System;
using CurrencyConverter.Services.Model;

namespace CurrencyConverter.Services.Logic
{
	public class CurrencyLogic
	{
		public double ConvertCurrency(CurrencyModel model)
		{
			double convertedTotal = 0.0;

            if (model.FromCurrency == model.ToCurrency)
            {
                convertedTotal = model.Amount;
            }
            if (model.FromCurrency == "USD")
            {
                if (model.ToCurrency == "EUR")
                {

                }
            }
            if (model.FromCurrency == "EUR")
            {
                if (model.ToCurrency == "USD")
                {

                }
            }




            return convertedTotal;
		}
	}
}

