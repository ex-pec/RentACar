using MvcWebUI.Helper;
using RentACar.Application.Abstractions.Service.Account;
using RentACar.Application.Abstractions.Service.Model;
using RentACar.MVC.Helper;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RentACar.MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        private readonly IAccountService accountService;
        private readonly ResponseHelper responseHelper = new ResponseHelper();
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
            var res = await accountService.LoginUserAsync(req);
            SessionHelper.KeepSessionInformation<UserDto>(StaticConsts.AboutProgram.SessionName, res);
            var thisRes = responseHelper.NullCheck(res, StaticConsts.ErrorMessage.LoginErrorMessage);

            //    Entities.ComplexTypes.ResponseModels.Response<UserInfoViewModel> UserInfo = _loginService.LoginUser(Req);
            //    sessionHelper.KeepSessionInformation<UserInfoViewModel>("UserInfo", UserInfo.Data);
            //    Session["Language"] = UserInfo.Data.new_dilidName.ToString().ToLower();

            //return Json(UserInfo, JsonRequestBehavior.AllowGet);
            return Json(thisRes, JsonRequestBehavior.AllowGet);
        }
    }
}