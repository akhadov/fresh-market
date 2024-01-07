namespace Domain.Entities.Basket;

public class ShoppingCart
{
    public decimal Subtotal { get; set; }

    public decimal Total { get; set; }

    public long ShoppingCartItemId { get; set; }
    public virtual ShoppingCartItem? ShoppingCartItem { get; set; }
}
