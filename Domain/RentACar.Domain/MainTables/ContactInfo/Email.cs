using System;

namespace RentACar.Domain
{
    public class Email : BaseSchema<Guid>
    {
        public Guid EMAIL_TYPE_ID { get; set; }

        public string EMAIL_ADDRESS { get; set; }
    }
}