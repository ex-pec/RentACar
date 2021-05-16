using RentACar.Application.Abstractions;
using System.Web.Mvc;

namespace RentACar.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClass1Service class1;
        public HomeController(IClass1Service class1)
        {
            this.class1 = class1;
        }
        public ActionResult Index()
        {
            var res = class1.MyMethod();
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