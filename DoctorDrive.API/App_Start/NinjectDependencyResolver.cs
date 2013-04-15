using Ninject;
using System.Web.Http.Dependencies;

namespace DoctorDrive.API.App_Start
{

    // Provides a Ninject implementation of IDependencyScope
    // which resolves services using the Ninject container.

    // This class is the resolver, but it is also the global scope
    // so we derive from NinjectScope.
    public class NinjectDependencyResolver : NinjectDependencyScope, IDependencyResolver
    {
        IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
            : base(kernel)
        {
            this.kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(kernel.BeginBlock());
        }
    }

}
