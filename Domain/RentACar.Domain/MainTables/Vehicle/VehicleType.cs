using System;

namespace RentACar.Domain
{
    public class VehicleType : BaseSchema<Guid>
    {
        public string TYPE { get; set; }
    }
}
