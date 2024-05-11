namespace Domain.Customers;

public record Address
{
    public Address(string line1, string? line2, string city, string state, string zipCode, string country)
    {

        Line1 = line1;
        Line2 = line2;
        City = city;
        State = state;
        ZipCode = zipCode;
        Country = country;
    }

    public string Line1 { get; }
    public string? Line2 { get; }
    public string City { get; }
    public string State { get; }
    public string ZipCode { get; }
    public string Country { get; }

    private Address() { }
}
