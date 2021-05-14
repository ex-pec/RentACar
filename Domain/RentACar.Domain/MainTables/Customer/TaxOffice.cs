using System;

namespace RentACar.Domain
{
    public class TaxOffice : BaseSchema<Guid>
    {
        public Guid ADDRESS_ID { get; set; }

        public string NAME { get; set; }
    }
}