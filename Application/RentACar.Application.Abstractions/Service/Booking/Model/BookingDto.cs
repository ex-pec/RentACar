using System;

namespace RentACar.Application.Abstractions.Service.Model
{
    public class BookingDto
    {
        public Guid CUSTOMER_ID { get; set; }

        public Guid VEHICLE_ID { get; set; }

        public Guid EXCHANGE_RATE_ID { get; set; }

        public Guid DELIVERY_OFFICE_ID { get; set; }

        public Guid RECEIVE_OFFICE_ID { get; set; }

        public bool DRIVER { get; set; }

        public DateTime START_DATE { get; set; }

        public DateTime END_DATE { get; set; }

        public decimal AMOUNT { get; set; }
    }
}
