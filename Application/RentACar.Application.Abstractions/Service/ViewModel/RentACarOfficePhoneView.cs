using System;

namespace RentACar.Application.Abstractions.Service.ViewModel
{
    public class RentACarOfficePhoneView
    {
        public Guid RENT_A_CAR_OFFICE_ID { get; set; }
        public Guid PHONE_ID { get; set; }
        public Guid PHONE_TYPE_ID { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string PHONE_TYPE { get; set; }
    }
}
