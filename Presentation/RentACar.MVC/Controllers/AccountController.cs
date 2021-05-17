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
            var res = await accountService.LoginUserAsync(req);
            SessionHelper.KeepSessionInformation(res);
            var thisRes = responseHelper.NullCheck(res, StaticConsts.ErrorMessage.LoginErrorMessage);

            return Json(thisRes, JsonRequestBehavior.AllowGet);
        }
    }
}