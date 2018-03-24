
using System.Configuration;
using System.Net.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CircuitBreaker;
using Ninject;
using Ninject.Web.Mvc;
using Services;

namespace Website
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterDependencyResolver();
        }

        private static void RegisterDependencyResolver()
        {
            var kernel = new StandardKernel();

            // you may need to configure your container here?
            RegisterServices(kernel);

            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IService>().To<Service>().WithConstructorArgument("baseAddress", ConfigurationManager.AppSettings["ExternalServiceAddress"]);
            kernel.Bind<ICircuitBreaker<HttpResponseMessage>>().To<CircuitBreaker<HttpResponseMessage>>();
            kernel.Bind<IHttpClientFactory>().To<HttpClientFactory>();
        }
    }
}
