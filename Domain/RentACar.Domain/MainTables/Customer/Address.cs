using System;

namespace RentACar.Domain
{
    public class Address : BaseSchema<Guid>
    {
        public Guid DISTRICT_ID { get; set; }

        public Guid FULLY_ADDRESS_ID { get; set; }

        public Guid CUSTOMER_ID { get; set; }
    }
}