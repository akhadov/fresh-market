using SharedKernel.Base;

namespace Domain.Customers;

public record CustomerCreatedEvent(CustomerId CustomerId, string FirstName, string LastName) : DomainEvent
{
    public static CustomerCreatedEvent Create(Customer customer) =>
        new(customer.Id, customer.FirstName, customer.LastName);
}
