using Domain.Entities.Common;

namespace Domain.Entities.Basket;

public class BasketCheckout
{
    public string UserName { get; set; }
    public decimal TotalPrice { get; set; }

    public long AddressId { get; set; }
    public virtual Address? Address { get; set; }

}
