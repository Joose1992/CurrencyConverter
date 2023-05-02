using System;
namespace CurrencyConverter.Services.Model
{
	public class CurrencyModel
	{
        public string FromCurrency { get; set; } = null!;
        public string ToCurrency { get; set; } = null!;
        public double Amount { get; set; }
        public List<string> CurrencyList { get; set; } = null!;
        public int ConvertedResult { get; set; }
    }
}

