using RentACar.Application.Abstractions.Application;
using RentACar.Application.Abstractions.Service.Model;
using System.Threading.Tasks;

namespace RentACar.Application.Abstractions.Service
{
    public interface IAccountService : IApplicationService
    {
        Task<ResTry> LoginUserAsync();
    }
}