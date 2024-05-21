using SharedKernel;

namespace Domain.Customers;

public sealed record Email
{
    private Email(string value) => Value = value;

    public string Value { get; }

    public static Result<Email> Create(string? email)
    {
        if (string.IsNullOrEmpty(email))
        {
            return Result.Failure<Email>(EmailErrors.Empty);
        }

        //if (email.Split('@').Length != 2)
        //{
        //    return Result.Failure<Email>(EmailErrors.InvalidFormat);
        //}

        return new Email(email);
    }
}
