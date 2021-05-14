using System;

namespace RentACar.Domain
{
    public class Role : BaseSchema<Guid>
    {
        public string NAME { get; set; }
    }
}
