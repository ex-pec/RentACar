﻿using MvcWebUI.Helper;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RentACar.MVC.Controllers
{
    [SessionAuthorize]
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
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