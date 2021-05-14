using System;

namespace RentACar.Domain
{
    public class DailyWages : BaseSchema<Guid>
    {
        public decimal WAGE { get; set; }
    }
}
