using RentACar.Application.Abstractions.Service.Account;
using RentACar.Application.Abstractions.Service.Account.Model.Procedure;
using RentACar.Application.Abstractions.Service.Model;
using RentACar.Application.Helper.ProcedureConst;
using RentACar.Dal.Dapper;
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
        public async Task<UserDto> LoginUserAsync(LoginReq req)
        {
            var loginProcedureReq = new LoginProcedureReq(req);

            var res = await dpRepositoriesService.GetSp<LoginProcedureReq, UserDto>(ProcedureNames.GetUserByUsername, loginProcedureReq);
            return res;
        }
    }
}
