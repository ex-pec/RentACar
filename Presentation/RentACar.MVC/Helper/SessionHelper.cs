using System.Web;

namespace MvcWebUI.Helper
{
    public static class SessionHelper
    {
        public static void KeepSessionInformation<T>(string SessionName, T SessionModel)
        {
            HttpContext.Current.Session[SessionName] = SessionModel;
            HttpContext.Current.Session.Timeout = 200;//200 minute session timeout
        }

        public static T GetSessionModel<T>(string SessionName)
        {
            return (T)HttpContext.Current.Session[SessionName];
        }
    }
}