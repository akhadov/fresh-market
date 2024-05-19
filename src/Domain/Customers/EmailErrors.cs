using SharedKernel;

namespace Domain.Customers;

public static class EmailErrors
{
    public static readonly Error Empty = Error.Problem("Email.Empty", "Email is empty");

    public static readonly Error InvalidFormat = Error.Problem(
        "Email.InvalidFormat", "Email format is invalid");
}
