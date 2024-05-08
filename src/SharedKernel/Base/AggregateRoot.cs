using SharedKernel.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedKernel.Base;

public abstract class AggregateRoot<TId> : Entity<TId>, IAggregateRoot
{
    private readonly List<DomainEvent> _domainEvents = [];

    [NotMapped]
    public IReadOnlyList<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void AddDomainEvent(DomainEvent domainEvent) => _domainEvents.Add(domainEvent);

    public void RemoveDomainEvent(DomainEvent domainEvent) => _domainEvents.Remove(domainEvent);

    public void ClearDomainEvents() => _domainEvents.Clear();
}
