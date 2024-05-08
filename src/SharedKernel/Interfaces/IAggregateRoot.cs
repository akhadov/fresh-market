using SharedKernel.Base;

namespace SharedKernel.Interfaces;

public interface IAggregateRoot
{
    public IReadOnlyList<DomainEvent> DomainEvents { get; }

    public void AddDomainEvent(DomainEvent domainEvent);

    public void RemoveDomainEvent(DomainEvent domainEvent);

    public void ClearDomainEvents();
}
