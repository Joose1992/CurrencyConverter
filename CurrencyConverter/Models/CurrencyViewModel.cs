using System;
namespace CurrencyConverter.Models
{
	public class CurrencyViewModel
	{
		public string FromCurrency { get; set; }
		public string ToCurrency { get; set; }
		public int Amount { get; set; }
		public List<string> CurrencyList { get; set; }
		public int ConvertedResult { get; set; }

		public CurrencyViewModel()
		{
			CurrencyList = new List<string>
			{
				"USD",
				"EUR"
			};
		}
	}
}

