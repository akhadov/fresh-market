using SharedKernel.Base;

namespace Domain.Customers;

public record CustomerCreatedEvent(Customer Customer) : DomainEvent;