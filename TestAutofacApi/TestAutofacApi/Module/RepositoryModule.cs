using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace TestAutofacApi.Module
{
	public class RepositoryModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterAssemblyTypes(Assembly.Load("Books.Repository"))
				.Where(n => n.Name.EndsWith("Repository"))
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();
		}
	}
}