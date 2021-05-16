using RentACar.Application.Abstractions.Service.Model;

namespace RentACar.Application.Abstractions.Service.Account.Model.Procedure
{
    public class LoginProcedureReq
    {
        public LoginProcedureReq(LoginReq req)
        {
            this.Username = req.Username;
        }
        public string Username { get; set; }
    }
}
