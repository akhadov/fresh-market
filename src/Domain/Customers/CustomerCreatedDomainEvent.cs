using SharedKernel.Base;

namespace Domain.Customers;

public record CustomerCreatedDomainEvent(CustomerId CustomerId, string FirstName, string LastName) : DomainEvent
{
    public static CustomerCreatedDomainEvent Create(Customer customer) =>
        new(customer.Id, customer.FirstName, customer.LastName);
}
