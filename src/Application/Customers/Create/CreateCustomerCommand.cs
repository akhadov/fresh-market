using Application.Abstractions.Messaging;

namespace Application.Customers.Create;

public sealed record CreateCustomerCommand(string Email, string FirstName, string LastName)
    : ICommand<Guid>;
