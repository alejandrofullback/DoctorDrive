using DoctorDrive.API.App_Start;
using DoctorDrive.Infra.Interface.IRepository;
using DoctorDrive.Infra.Interface.IService;
using DoctorDrive.Infra.Repository;
using DoctorDrive.Infra.Service;
using Macaco.Infraestructure.Domain.Events;
using Macaco.Infraestructure.Mapping;

[assembly: WebActivator.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]

namespace DoctorDrive.API.App_Start
{
	using System;
	using System.Web;

	using Microsoft.Web.Infrastructure.DynamicModuleHelper;

	using Ninject;
	using Ninject.Web.Common;
	using System.Web.Http;

	public static class NinjectWebCommon
	{
		private static readonly Bootstrapper bootstrapper = new Bootstrapper();

		/// <summary>
		/// Starts the application
		/// </summary>
		public static void Start()
		{
			DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
			DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
			bootstrapper.Initialize(CreateKernel);
		}

		/// <summary>
		/// Stops the application.
		/// </summary>
		public static void Stop()
		{
			bootstrapper.ShutDown();
		}

		/// <summary>
		/// Creates the kernel that will manage your application.
		/// </summary>
		/// <returns>The created kernel.</returns>
		private static IKernel CreateKernel()
		{
			var kernel = new StandardKernel();
			kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
			kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

			RegisterServices(kernel);

			GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
			DomainEvents.Container = new NinjectEventContainer(kernel);

			return kernel;
		}

		/// <summary>
		/// Load your modules or register your services here!
		/// </summary>
		/// <param name="kernel">The kernel.</param>
		private static void RegisterServices(IKernel kernel)
		{
			kernel.Bind<IMapper>().To<AutoMapperService>();

			//Repositories
			kernel.Bind<IPersonRepository>().To<PersonRepository>();
			kernel.Bind<IPatientRepository>().To<PatientRepository>();
			kernel.Bind<ICaseRepository>().To<CaseRepository>();
			kernel.Bind<IDoctorRepository>().To<DoctorRepository>();

			//Services
			kernel.Bind<ICaseService>().To<CaseService>();

		}
	}
}
