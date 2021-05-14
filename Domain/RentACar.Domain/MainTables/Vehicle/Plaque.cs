using System;

namespace RentACar.Domain
{
    public class Plaque : BaseSchema<Guid>
    {
        public string PLAQUE_NUMBER { get; set; }
    }
}
