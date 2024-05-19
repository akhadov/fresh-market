using FluentValidation;

namespace Application.Customers.Create;

internal sealed class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        RuleFor(c => c.FirstName)
            .NotEmpty().WithErrorCode(CustomerErrorCodes.CreateCustomer.MissingFirstName);

        RuleFor(c => c.LastName)
            .NotEmpty().WithErrorCode(CustomerErrorCodes.CreateCustomer.MissingLastName);

        RuleFor(c => c.Email)
            .NotEmpty().WithErrorCode(CustomerErrorCodes.CreateCustomer.MissingEmail)
            .EmailAddress().WithErrorCode(CustomerErrorCodes.CreateCustomer.InvalidEmail);
    }
}
