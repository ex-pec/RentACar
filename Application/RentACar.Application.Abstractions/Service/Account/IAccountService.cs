using RentACar.Application.Abstractions.Service.Model;
using System.Threading.Tasks;

namespace RentACar.Application.Abstractions.Service.Account
{
    public interface IAccountService : IApplicationService
    {
        Task<UserInfo> LoginUserAsync(LoginReq req);
    }
}