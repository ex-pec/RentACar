using System;

namespace RentACar.Application.Abstractions.Service.ViewModel
{
    public class CustomerPhoneView
    {
        public Guid CUSTOMER_ID { get; set; }

        public Guid PHONE_ID { get; set; }

        public Guid PHONE_TYPE_ID { get; set; }

        public string PHONE_NUMBER { get; set; }

        public string PHONE_TYPE { get; set; }
    }
}
