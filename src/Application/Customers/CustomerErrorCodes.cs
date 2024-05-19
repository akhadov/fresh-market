namespace Application.Customers;

public static class CustomerErrorCodes
{
    public static class CreateCustomer
    {
        public const string MissingFirstName = nameof(MissingFirstName);
        public const string MissingLastName = nameof(MissingLastName);
        public const string MissingEmail = nameof(MissingEmail);
        public const string InvalidEmail = nameof(InvalidEmail);
    }
}
