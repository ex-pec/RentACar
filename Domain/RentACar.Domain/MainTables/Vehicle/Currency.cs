using System;

namespace RentACar.Domain
{
    public class Currency : BaseSchema<Guid>
    {
        public string NAME { get; set; }

        public string SYMBOL { get; set; }
    }
}
