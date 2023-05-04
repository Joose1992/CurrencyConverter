using System;
using CurrencyConverter.Services.Model;

namespace CurrencyConverter.Services.Interfaces
{
	public interface ICurrencyLogic
	{
		public double ConvertCurrency(CurrencyModel model);
	}
}

