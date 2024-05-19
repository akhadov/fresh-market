using SharedKernel.Base;

namespace Domain.Customers;

public record CustomerCreatedEvent(CustomerId CustomerId) : DomainEvent
{
    public static CustomerCreatedEvent Create(Customer customer) =>
        new(customer.Id);
}
