using System;

namespace RentACar.Application.Abstractions.Service.ViewModel
{
    public class CompanyDetailView
    {
        public Guid COMPANY_DETAIL_ID { get; set; }

        public Guid ADDRESS_ID { get; set; }

        public Guid ADDRESS_TYPE_ID { get; set; }

        public Guid FULLY_ADDRESS_ID { get; set; }

        public Guid DISTRICT_ID { get; set; }

        public Guid PROVINCE_ID { get; set; }

        public Guid TAX_OFFICE_ID { get; set; }

        public Guid TAX_OFFICE_ADDRESS_ID { get; set; }

        public Guid TAX_OFFICE_ADDRESS_TYPE_ID { get; set; }

        public Guid TAX_OFFICE_FULLY_ADDRESS_ID { get; set; }

        public Guid TAX_OFFICE_DISTRICT_ID { get; set; }

        public Guid TAX_OFFICE_PROVINCE_ID { get; set; }

        public string ADDRESS_TYPE { get; set; }

        public string FULLY_ADDRESS { get; set; }

        public string DISTRICT_NAME { get; set; }

        public string PROVINCE_NAME { get; set; }

        public string TAX_NUMBER { get; set; }

        public string TITLE { get; set; }

        public string TAX_OFFICE_ADDRESS_TYPE { get; set; }

        public string TAX_OFFICE_FULLY_ADDRESS { get; set; }

        public string TAX_OFFICE_DISTRICT_NAME { get; set; }

        public string TAX_OFFICE_PROVINCE_NAME { get; set; }

        public string TAX_OFFICE_NAME { get; set; }
    }
}
