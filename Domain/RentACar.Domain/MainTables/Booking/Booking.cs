using System;

namespace RentACar.Domain
{
    public class Booking : BaseSchema<Guid>
    {
        public Guid CUSTOMER_ID { get; set; }

        public Guid VEHICLE_ID { get; set; }

        public Guid EXCHANGE_RATE_ID { get; set; }

        public DateTime START_DATE { get; set; }

        public DateTime END_DATE { get; set; }

        public decimal AMOUNT { get; set; }
    }
}