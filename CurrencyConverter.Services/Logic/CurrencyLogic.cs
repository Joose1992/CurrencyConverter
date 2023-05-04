using System;
using CurrencyConverter.Services.Interfaces;
using CurrencyConverter.Services.Model;

namespace CurrencyConverter.Services.Logic
{
	public class CurrencyLogic : ICurrencyLogic
	{
		public double ConvertCurrency(CurrencyModel model)
		{
			double convertedTotal = 0.0;
            double AmountToConvert = model.Amount;
            double dollarToEuro = 0.91;
            double euroToDollar = 1.10;
            double dollarsToPesos = 17.95;
            double euroToPesos = 19.79;
            double pesosToDollars = 0.056;
            double pesosToEuro = 0.50;

            if (model.FromCurrency == model.ToCurrency)
            {
                convertedTotal = model.Amount;
            }
            if (model.FromCurrency == "USD")
                
            {
                if (model.ToCurrency == "EUR")
                {
                    convertedTotal = AmountToConvert * dollarToEuro;
                }
                if (model.ToCurrency == "MXPESOS")
                {
                    convertedTotal = AmountToConvert * dollarsToPesos;
                }
            }
            if (model.FromCurrency == "EUR")
            {
                if (model.ToCurrency == "USD")
                {
                    convertedTotal = AmountToConvert * euroToDollar;
                }
                if (model.ToCurrency == "MXPESOS")
                {
                    convertedTotal = AmountToConvert * euroToPesos;
                }
            }
            if (model.FromCurrency == "MXPESOS")
            {
                if(model.ToCurrency == "USD")
                {
                    convertedTotal = AmountToConvert * pesosToDollars;
                }
                if (model.ToCurrency == "EUR")
                {
                    convertedTotal = AmountToConvert * pesosToEuro;
                }
            }




            return convertedTotal;
		}
	}
}

