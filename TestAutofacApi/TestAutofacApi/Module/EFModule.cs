﻿using Autofac;
using Books.Model;
using Books.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestAutofacApi.Module
{
	public class EFModule : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterModule(new RepositoryModule());

			builder.RegisterType(typeof(BookSampleEntities)).As(typeof(DbContext)).InstancePerLifetimeScope();
			builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
		}
	}
}