namespace Domain.Entities.Buyers;

public class PaymentMethod
{
    public string Alias { get; set; }

    public string CardNumber { get; set; }

    public string SecurityNumber { get; set; }

    public string CardHolderName { get; set; }

    public DateTime ExpirationDate { get; set; }

    public CardType CardType { get; set; }
}
