using System;

namespace RentACar.Application.Abstractions.Service.ViewModel
{
    public class ProvinceDistrictView
    {
        public Guid DISTRICT_ID { get; set; }
        public Guid PROVINCE_ID { get; set; }
        public string DISTRICT_NAME { get; set; }
        public string PROVINCE_NAME { get; set; }
    }
}
