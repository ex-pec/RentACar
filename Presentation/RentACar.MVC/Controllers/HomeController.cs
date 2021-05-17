using MvcWebUI.Helper;
using RentACar.Application.Abstractions.Service.Model;
using RentACar.MVC.Helper;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RentACar.MVC.Controllers
{
    [SessionAuthorize]
    public class HomeController : Controller
    {
        private readonly ResponseHelper responseHelper = new ResponseHelper();
        public async Task<ActionResult> Index()
        {
            var res = SessionHelper.GetSessionModel<UserInfo>();
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