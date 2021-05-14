using System;

namespace RentACar.Domain
{
    public class ChassisNumber : BaseSchema<Guid>
    {
        public string CHASSIS_NUMBER { get; set; }
    }
}
