namespace Domain.Entities.Buyers;

public class Buyer
{
    public string UserId { get; set; }

    public string Name { get; set; }

    public IEnumerable<PaymentMethod> PaymentMethods { get; set; }

}
