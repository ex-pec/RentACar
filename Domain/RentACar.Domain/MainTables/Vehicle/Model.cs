using System;

namespace RentACar.Domain
{
    public class Model : BaseSchema<Guid>
    {
        public Guid BRAND_ID { get; set; }

        public string NAME { get; set; }
    }
}
