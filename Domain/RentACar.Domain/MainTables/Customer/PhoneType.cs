using System;

namespace RentACar.Domain
{
    public class PhoneType : BaseSchema<Guid>
    {
        public string TYPE { get; set; }
    }
}