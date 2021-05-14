using System;

namespace RentACar.Domain
{
    public class ModelYear : BaseSchema<Guid>
    {
        public short YEAR { get; set; }
    }
}
