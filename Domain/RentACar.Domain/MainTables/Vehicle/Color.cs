using System;

namespace RentACar.Domain
{
    public class Color : BaseSchema<Guid>
    {
        public string NAME { get; set; }
    }
}
