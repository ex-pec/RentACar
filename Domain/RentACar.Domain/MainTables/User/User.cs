using RentACar.Domain.Abstractions;
using System;

namespace RentACar.Domain
{
    public class User : IEntity<Guid>
    {
        public Guid ID { get; set; }

        public Guid PHONE_ID { get; set; }

        public string NAME { get; set; }

        public string SURNAME { get; set; }

        public string EMAIL { get; set; }

        public string PASSWORD_HASH { get; set; }

        public string SECURITY_STAMP { get; set; }

        public byte[] PROFILE_PHOTO { get; set; }
    }
}
