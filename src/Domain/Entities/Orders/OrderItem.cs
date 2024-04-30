namespace Domain.Entities.Orders;

public class OrderItem
{
    public decimal UnitPrice { get; private set; }

    public decimal Discount { get; private set; }

    public int Units { get; private set; }

    public int ProductId { get; private set; }
    public virtual Product? Product { get; set; }

}
