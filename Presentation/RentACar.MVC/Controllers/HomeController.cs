using RentACar.Application.Abstractions.Service;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RentACar.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccountService accountService;
        public HomeController(IAccountService accountService)
        {
            this.accountService = accountService;
        }
        public async Task<ActionResult> Index()
        {
            var res = await accountService.LoginUserAsync();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}