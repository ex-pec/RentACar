using System;

namespace RentACar.Domain
{
    public class ExchangeRate : BaseSchema<Guid>
    {
        public Guid CURRENCY_TARGET_ID { get; set; }

        public Guid CURRENCY_SOURCE_ID { get; set; }

        public Guid EXCHANGE_RATE_TYPE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public DateTime DATE { get; set; }
    }
}
