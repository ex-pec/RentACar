using System;

namespace RentACar.Domain
{
    public class Phone : BaseSchema<Guid>
    {
        public Guid PHONE_TYPE_ID { get; set; }

        public Guid CUSTOMER_ID { get; set; }

        public string PHONE_NUMBER { get; set; }
    }
}