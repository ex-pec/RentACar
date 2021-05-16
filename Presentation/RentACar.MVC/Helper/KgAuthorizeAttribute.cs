using System.Web.Mvc;

namespace MvcWebUI.Helper
{
    public class KgAuthorizeAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //SessionHelper sessionHelper = new SessionHelper();

            //base.OnActionExecuting(filterContext);
            //UserInfoViewModel UserInfo = sessionHelper.GetSessionModel<UserInfoViewModel>("UserInfo");
            //if (UserInfo.new_rol != 3)//1 is admin
            //{//if this user not a admin go to home page
            //    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
            //    {
            //        controller = "Home",
            //        action = "Index"
            //    }));
            //}
        }
    }
}