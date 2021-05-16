using Autofac;
using Autofac.Integration.Mvc;
using RentACar.Application.Abstractions.Application;
using System;
using System.Linq;

namespace RentACar.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        //Service must be end with this value
        private const string ServiceEndName = "Service";

        /// <summary>
        /// Registers the application services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static IContainer RegisterApplicationServices()
        {
            var builder = new ContainerBuilder();

            var allAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            builder.RegisterControllers(allAssemblies);
            //Service Assembly not interface
            var assemblies = allAssemblies.Where(_ => _.GetTypes()
            .Where(t => typeof(IApplicationService).IsAssignableFrom(t) && !t.IsInterface)
            .Any()).ToArray();

            builder.RegisterAssemblyTypes(assemblies).Where(t => t.Name.EndsWith(ServiceEndName)).AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
