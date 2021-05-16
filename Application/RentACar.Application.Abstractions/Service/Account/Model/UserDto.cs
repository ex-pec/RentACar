using System;

namespace RentACar.Application.Abstractions.Service.Model
{
    public class UserDto
    {
        public Guid ID { get; set; }

        public string PHONE { get; set; }

        public string NAME { get; set; }

        public string SURNAME { get; set; }

        public string USERNAME { get; set; }

        public string PASSWORD_HASH { get; set; }

        public string SECURITY_STAMP { get; set; }

        public byte[] PROFILE_PHOTO { get; set; }
    }
}
