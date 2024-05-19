using SharedKernel;

namespace Domain.Customers;

public sealed record FirstName
{
    public FirstName(string? value)
    {
        Ensure.NotNullOrEmpty(value);

        Value = value;
    }

    public string Value { get; }
}
