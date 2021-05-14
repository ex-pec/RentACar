using System;

namespace RentACar.Domain
{
    public class ExchangeRate : BaseSchema<Guid>
    {
        public Guid CURRENCY_ID { get; set; }

        public Guid EXCHANGE_RATE_TYPE_ID { get; set; }

        public decimal AMOUNT { get; set; }
    }
}
