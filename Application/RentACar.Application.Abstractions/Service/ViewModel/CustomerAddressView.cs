using System;

namespace RentACar.Application.Abstractions.Service.ViewModel
{
    public class CustomerAddressView
    {
        public Guid CUSTOMER_ID { get; set; }

        public Guid ADDRESS_ID { get; set; }

        public Guid ADDRESS_TYPE_ID { get; set; }

        public Guid FULLY_ADDRESS_ID { get; set; }

        public Guid DISTRICT_ID { get; set; }

        public Guid PROVINCE_ID { get; set; }

        public string ADDRESS_TYPE { get; set; }

        public string FULLY_ADDRESS { get; set; }

        public string DISTRICT_NAME { get; set; }

        public string PROVINCE_NAME { get; set; }
    }
}
