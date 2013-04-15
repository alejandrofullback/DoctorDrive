using System.Collections.Generic;

namespace Macaco.Infraestructure.Domain.Events
{
    public interface IEventContainer
    {
        IEnumerable<IDomainEventHandler<T>> Handlers<T>(T domainEvent)
            where T : IDomainEvent;
    }
}