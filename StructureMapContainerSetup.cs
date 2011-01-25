using System;
using System.Web.Mvc;
using AppHarborMotoWilliams.Controllers;
using AppHarborMotoWilliams.Services;
using StructureMap;

namespace AppHarborMotoWilliams
{
	public class StructureMapContainerSetup
	{
		public static void SetUp()
		{
			IContainer container = new Container(
					x =>
					{
						x.For<IMotoService>()
							.Use<MotoService>();
						x.For<ILogger>()
							.Use<NullLogger>();
					});
			DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
		}

	}
}