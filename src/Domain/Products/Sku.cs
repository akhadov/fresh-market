namespace Domain.Products;

public record Sku
{
    private const int DefaultLenght = 8;

    private Sku(string value) => Value = value;

    public string Value { get; init; }

    public static explicit operator string(Sku sku) => sku.Value;

    public static Sku? Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException(nameof(value));
        }

        if (value.Length != DefaultLenght)
        {
            throw new ArgumentException(nameof(value));
        }

        return new Sku(value);
    }
}
