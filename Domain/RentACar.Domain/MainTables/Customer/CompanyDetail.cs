using System;

namespace RentACar.Domain
{
    public class CompanyDetail : BaseSchema<Guid>
    {
        public Guid TAX_OFFICE_ID { get; set; }

        public Guid CUSTOMER_ID { get; set; }

        public string TAX_NUMBER { get; set; }

        public string TITLE { get; set; }
    }
}