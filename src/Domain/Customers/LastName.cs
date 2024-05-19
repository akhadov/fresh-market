using SharedKernel;

namespace Domain.Customers;

public sealed record LastName
{
    public LastName(string? value)
    {
        Ensure.NotNullOrEmpty(value);

        Value = value;
    }

    public string Value { get; }
}