using System;

namespace RentACar.Domain
{
    public class Province : BaseSchema<Guid>
    {
        public string NAME { get; set; }
    }
}