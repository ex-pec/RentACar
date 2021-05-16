using System;

namespace RentACar.Domain
{
    public class EmailType : BaseSchema<Guid>
    {
        public string TYPE { get; set; }
    }
}