using System;

namespace RentACar.Domain
{
    public class District : BaseSchema<Guid>
    {
        public Guid PROVINCE_ID { get; set; }

        public string NAME { get; set; }
    }
}