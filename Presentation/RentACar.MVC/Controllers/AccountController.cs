using RentACar.Application.Abstractions.Service.Account;
using RentACar.Application.Abstractions.Service.Model;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RentACar.MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        private readonly IAccountService accountService;
        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        public async Task<ActionResult> Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(LoginReq req)
        {
            //LoginControl is endpoint file resource field name
            var res=await accountService.LoginUserAsync(req);
            //    Entities.ComplexTypes.ResponseModels.Response<UserInfoViewModel> UserInfo = _loginService.LoginUser(Req);
            //    sessionHelper.KeepSessionInformation<UserInfoViewModel>("UserInfo", UserInfo.Data);
            //    Session["Language"] = UserInfo.Data.new_dilidName.ToString().ToLower();

            //return Json(UserInfo, JsonRequestBehavior.AllowGet);
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}