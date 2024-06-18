using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Customers;
using SharedKernel;

namespace Application.Customers.Create;

internal sealed class CreateCustomerCommandHandler(
    ICustomerRepository customerRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<CreateCustomerCommand, Guid>
{
    public async Task<Result<Guid>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        Result<Email> emailResult = Email.Create(request.Email);
        if (emailResult.IsFailure)
        {
            return Result.Failure<Guid>(emailResult.Error);
        }

        Email email = emailResult.Value;
        if (!await customerRepository.IsEmailUniqueAsync(email))
        {
            return Result.Failure<Guid>(CustomerErrors.EmailNotUnique);
        }

        var firstName = new FirstName(request.FirstName);
        var lastName = new LastName(request.LastName);
        var customer = Customer.Create(email, firstName, lastName);

        await customerRepository.AddAsync(customer, cancellationToken);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return customer.Id.Value;
    }
}
