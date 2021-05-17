using RentACar.Application.Abstractions.Service.ViewModel;
using System.Collections.Generic;

namespace RentACar.Application.Abstractions.Service.Model
{
    public class UserInfo
    {
        public UserDto UserDto { get; set; }
        public List<UserRoleView> UserRoleViewList { get; set; }
        public List<UserAddressView> UserAddressViewList { get; set; }
        public List<UserPhoneView> UserPhoneViewList { get; set; }
        public List<UserEmailView> UserEmailViewList { get; set; }
    }
}
