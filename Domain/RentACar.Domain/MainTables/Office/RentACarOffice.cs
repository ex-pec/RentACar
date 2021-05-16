using System;

namespace RentACar.Domain
{
    public class RentACarOffice : BaseSchema<Guid>
    {
        public Guid ADDRESS_ID { get; set; }

        public string TITLE { get; set; }
    }
}