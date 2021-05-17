using System;

namespace RentACar.Application.Abstractions.Service.ViewModel
{
	public class ExchangeRateView
	{
		public Guid EXCHANGE_RATE_ID { get; set; }
		public Guid CURRENCY_TARGET_ID { get; set; }
		public Guid CURRENCY_SOURCE_ID { get; set; }
		public Guid EXCHANGE_RATE_TYPE_ID { get; set; }
		public decimal AMOUNT { get; set; }
		public DateTime DATE { get; set; }
		public string CURRENCY_TARGET_NAME { get; set; }
		public string CURRENCY_SOURCE_NAME { get; set; }
		public string EXCHANGE_RATE_TYPE { get; set; }
	}
}
