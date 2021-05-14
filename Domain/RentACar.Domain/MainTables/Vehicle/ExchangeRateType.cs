using System;

namespace RentACar.Domain
{
    public class ExchangeRateType : BaseSchema<Guid>
    {
        public string TYPE { get; set; }
    }
}
