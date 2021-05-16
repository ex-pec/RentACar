using System;

namespace RentACar.Domain
{
    public class Vehicle : BaseSchema<Guid>
    {
        public Guid MODEL_ID { get; set; }

        public Guid MODEL_YEAR_ID { get; set; }

        public Guid CHASSIS_NUMBER_ID { get; set; }

        public Guid COLOR_ID { get; set; }

        public Guid VEHICLE_TYPE_ID { get; set; }

        public Guid PLAQUE_ID { get; set; }

        public Guid CAR_OFFICE_ID { get; set; }
    }
}
