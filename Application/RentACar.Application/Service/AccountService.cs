using RentACar.Application.Abstractions.Service.Account;
using RentACar.Application.Abstractions.Service.Account.Model.Procedure;
using RentACar.Application.Abstractions.Service.Model;
using RentACar.Application.Abstractions.Service.ViewModel;
using RentACar.Application.Helper.Password;
using RentACar.Application.Helper.ProcedureConst;
using RentACar.Dal.Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Application.Service
{
    public class AccountService : IAccountService
    {
        private readonly IDpRepositoriesService dpRepositoriesService;
        public AccountService(IDpRepositoriesService dpRepositoriesService)
        {
            this.dpRepositoriesService = dpRepositoriesService;
        }
        public async Task<UserInfo> LoginUserAsync(LoginReq req)
        {
            var res = await GetUserInfoAsync(req);
            if (res == null)
                return null;

            var passwordCheck = PasswordHelper.PasswordsMatch(req.Password, res.UserDto.SECURITY_STAMP, res.UserDto.PASSWORD_HASH);
            if (!passwordCheck)
                return null;

            return res;
        }

        private async Task<UserInfo> GetUserInfoAsync(LoginReq req)
        {
            var res = new UserInfo();
            var username = new UsernameModel(req);
            var userDto = await GetUserDtoAsync(username);
            if (userDto == null)
                return null;

            var userId = new UserIdModel(userDto);
            var userRoleViewList = await GetUserRoleViewListAsync(userId);
            var userAddressViewList = await GetUserAddressViewListAsync(userId);
            var userPhoneViewList = await GetUserPhoneViewListAsync(userId);
            var userEmailViewList = await GetUserEmailViewListAsync(userId);

            res.UserDto = userDto;
            res.UserRoleViewList = userRoleViewList;
            res.UserAddressViewList = userAddressViewList;
            res.UserPhoneViewList = userPhoneViewList;
            res.UserEmailViewList = userEmailViewList;
            return res;
        }
        private async Task<UserDto> GetUserDtoAsync(UsernameModel procedureReq)
        {
            return await dpRepositoriesService.GetSp<UsernameModel, UserDto>(ProcedureNames.GetUserByUsername, procedureReq);
        }
        private async Task<List<UserRoleView>> GetUserRoleViewListAsync(UserIdModel procedureReq)
        {
            return (await dpRepositoriesService.GetSpList<UserIdModel, UserRoleView>(ProcedureNames.GetUserRoleViewList, procedureReq)).ToList();
        }
        private async Task<List<UserAddressView>> GetUserAddressViewListAsync(UserIdModel procedureReq)
        {
            return (await dpRepositoriesService.GetSpList<UserIdModel, UserAddressView>(ProcedureNames.GetUserAddressViewList, procedureReq)).ToList();
        }
        private async Task<List<UserPhoneView>> GetUserPhoneViewListAsync(UserIdModel procedureReq)
        {
            return (await dpRepositoriesService.GetSpList<UserIdModel, UserPhoneView>(ProcedureNames.GetUserPhoneViewList, procedureReq)).ToList();
        }
        private async Task<List<UserEmailView>> GetUserEmailViewListAsync(UserIdModel procedureReq)
        {
            return (await dpRepositoriesService.GetSpList<UserIdModel, UserEmailView>(ProcedureNames.GetUserEmailViewList, procedureReq)).ToList();
        }
    }
}
