using System.Collections.Generic;
using Macaco.Infraestructure.Domain.Events;
using Ninject;

namespace DoctorDrive.API.App_Start
{
    public class NinjectEventContainer : IEventContainer
    {
        private readonly IKernel _kernerl;

        public NinjectEventContainer(IKernel kernal)
        {
            _kernerl = kernal;
        }

        public IEnumerable<IDomainEventHandler<T>> Handlers<T>(T domainEvent) where T : IDomainEvent
        {
            return _kernerl.GetAll<IDomainEventHandler<T>>();
        }
    }
}