using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TestAutofacApi.Module;
using Autofac.Integration.WebApi;

namespace TestAutofacApi
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			// Autofac configuration for web API
			var builder = new Autofac.ContainerBuilder();

			builder.RegisterApiControllers(typeof(WebApiApplication).Assembly).PropertiesAutowired();

			builder.RegisterModule(new RepositoryModule());
			builder.RegisterModule(new ServiceModule());
			builder.RegisterModule(new EFModule());

			var container = builder.Build();

			//DependencyResolver.SetResolver(new AutofacWebApiDependencyResolver(container));


			GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
		}
	}
}
