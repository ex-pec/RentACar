using Autofac.Integration.Mvc;
using RentACar.Infrastructure.Extensions;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RentACar.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = ServiceCollectionExtensions.RegisterApplicationServices();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
