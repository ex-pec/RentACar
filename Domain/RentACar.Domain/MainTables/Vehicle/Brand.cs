using System;

namespace RentACar.Domain
{
    public class Brand : BaseSchema<Guid>
    {
        public string NAME { get; set; }
    }
}
