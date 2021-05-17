using RentACar.Application.Abstractions.Service.ViewModel;
using System.Collections.Generic;

namespace RentACar.Application.Abstractions.Service.Model
{
    public class OfficeInfo
    {
        public RentACarOfficeView RentACarOfficeView { get; set; }
        public List<RentACarOfficeEmailView> RentACarOfficeEmailViewList { get; set; }
        public List<RentACarOfficePhoneView> RentACarOfficePhoneViewList { get; set; }
    }
}
