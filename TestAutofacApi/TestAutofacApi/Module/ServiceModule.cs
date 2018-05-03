using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace TestAutofacApi.Module
{
	public class ServiceModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterAssemblyTypes(Assembly.Load("Books.Business"))
				.Where(n => n.Name.EndsWith("Business"))
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();
		}
	}
}