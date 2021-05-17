using RentACar.Application.Abstractions.Service.ViewModel;
using System.Collections.Generic;

namespace RentACar.Application.Abstractions.Service.Model
{
    public class CustomerInfo
    {
        public CustomerDto CustomerDto { get; set; }
        public List<CompanyDetailView> CompanyDetailViewList { get; set; }
        public List<CustomerAddressView> CustomerAddressViewList { get; set; }
        public List<CustomerPhoneView> CustomerPhoneViewList { get; set; }
        public List<CustomerEmailView> CustomerEmailViewList { get; set; }
    }
}
