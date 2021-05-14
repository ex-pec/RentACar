using System;

namespace RentACar.Domain
{
    public class FullyAddress : BaseSchema<Guid>
    {
        public string ADDRESS { get; set; }
    }
}