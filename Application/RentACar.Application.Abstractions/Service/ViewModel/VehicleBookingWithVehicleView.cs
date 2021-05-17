using System;

namespace RentACar.Application.Abstractions.Service.ViewModel
{
    public class VehicleBookingWithVehicleView
    {
        public Guid VEHICLE_ID { get; set; }
        public Guid MODEL_YEAR_ID { get; set; }
        public Guid CHASSIS_NUMBER_ID { get; set; }
        public Guid COLOR_ID { get; set; }
        public Guid VEHICLE_TYPE_ID { get; set; }
        public Guid PLAQUE_ID { get; set; }
        public Guid CAR_OFFICE_ID { get; set; }
        public Guid MODEL_ID { get; set; }
        public Guid BRAND_ID { get; set; }
        public Guid VEHICLE_BOOKING_ID { get; set; }
        public Guid DAILY_WAGES_ID { get; set; }
        public Guid EXCHANGE_RATE_ID { get; set; }
        public Guid CURRENCY_TARGET_ID { get; set; }
        public Guid CURRENCY_SOURCE_ID { get; set; }
        public Guid EXCHANGE_RATE_TYPE_ID { get; set; }
        public string VEHICLE_TYPE { get; set; }
        public string COLOR_NAME { get; set; }
        public string CHASSIS_NUMBER { get; set; }
        public string PLAQUE_NUMBER { get; set; }
        public short YEAR { get; set; }
        public string MODEL_NAME { get; set; }
        public string BRAND_NAME { get; set; }
        public decimal WAGE { get; set; }
        public decimal AMOUNT { get; set; }
        public DateTime DATE { get; set; }
        public string CURRENCY_TARGET_NAME { get; set; }
        public string CURRENCY_SOURCE_NAME { get; set; }
        public string EXCHANGE_RATE_TYPE { get; set; }
    }
}
