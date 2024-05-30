using SharedKernel.Base;

namespace Domain.Customers;

public class Customer : AggregateRoot<CustomerId>
{
    private Customer(CustomerId id, Email email, FirstName firstName, LastName lastName, Address? address)
    {
        Id = id;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }

    private Customer() { }

    public Email Email { get; private set; }

    public FirstName FirstName { get; private set; }

    public LastName LastName { get; private set; }

    public Address? Address { get; private set; }


    public static Customer Create(Email email, FirstName firstName, LastName lastName)
    {

        var customer = new Customer { Id = new CustomerId(Guid.NewGuid()), Email = email, FirstName = firstName, LastName = lastName };

        customer.UpdateName(firstName, lastName);

        customer.AddDomainEvent(CustomerCreatedEvent.Create(customer));

        return customer;
    }

    public void UpdateName(FirstName firstName, LastName lastName)
    {

        FirstName = firstName;
        LastName = lastName;
    }

    public void UpdateAddress(Address address)
    {
        Address = address;
    }
}
