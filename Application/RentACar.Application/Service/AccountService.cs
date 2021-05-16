using RentACar.Application.Abstractions.Service;
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
        public async Task<ResTry> LoginUserAsync()
        {
            var obj = new ReqTry
            {
                UserName = "admin@adminuser.com"
            };

            var res = await dpRepositoriesService.GetSp<ReqTry, ResTry>(ProcedureNames.GetUserByUsername, obj);
            return res;
        }
    }
}
