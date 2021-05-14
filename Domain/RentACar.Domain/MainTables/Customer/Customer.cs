using System;

namespace RentACar.Domain
{
    public class Customer : BaseSchema<Guid>
    {
        public string NAME { get; set; }

        public string SURNAME { get; set; }

        public bool GENDER { get; set; }

        public DateTime DATE_OF_BIRTH { get; set; }

        public string TC_NUMBER { get; set; }
    }
}