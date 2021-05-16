using RentACar.MVC.Helper;
using System.Web.Mvc;

namespace MvcWebUI.Helper
{
    public class SessionAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext context)
        {
            if (context.HttpContext.Session[StaticConsts.AboutProgram.SessionName] == null)
            {
                context.Result = new RedirectResult("/Account");
            }
        }
    }
}