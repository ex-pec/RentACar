using System;

namespace RentACar.Domain
{
    public class AddressType : BaseSchema<Guid>
    {
        public string TYPE { get; set; }
    }
}