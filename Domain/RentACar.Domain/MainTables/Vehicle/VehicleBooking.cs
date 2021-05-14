using System;

namespace RentACar.Domain
{
    public class VehicleBooking : BaseSchema<Guid>
    {
        public Guid VEHICLE_ID { get; set; }

        public Guid EXCHANGE_RATE_ID { get; set; }

        public Guid DAILY_WAGES_ID { get; set; }
    }
}
