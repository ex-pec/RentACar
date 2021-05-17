using RentACar.MVC.Helper;
using System.Web;

namespace MvcWebUI.Helper
{
    public static class SessionHelper
    {
        public static void KeepSessionInformation<T>(T SessionModel)
        {
            HttpContext.Current.Session[StaticConsts.AboutProgram.SessionName] = SessionModel;
            HttpContext.Current.Session.Timeout = 200;//200 minute session timeout
        }

        public static T GetSessionModel<T>()
        {
            return (T)HttpContext.Current.Session[StaticConsts.AboutProgram.SessionName];
        }
    }
}