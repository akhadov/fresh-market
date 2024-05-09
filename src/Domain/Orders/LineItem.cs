using Domain.Products;
using SharedKernel.Base;

namespace Domain.Orders;

public class LineItem : AggregateRoot<LineItemId>
{
    public required OrderId OrderId { get; init; }

    public required ProductId ProductId { get; init; }

    public required Money Price { get; init; }

    public int Quantity { get; private set; }

    public Money Total => new(Price.Currency, Price.Amount * Quantity);

    private LineItem() { }

    internal static LineItem Create(OrderId orderId, ProductId productId, Money price, int quantity)
    {

        var lineItem = new LineItem
        {
            Id = new LineItemId(Guid.NewGuid()),
            OrderId = orderId,
            ProductId = productId,
            Price = price,
            Quantity = quantity
        };

        return lineItem;
    }

    internal void AddQuantity(int quantity) => Quantity += quantity;

    internal void RemoveQuantity(int quantity)
    {
        Quantity -= quantity;
    }
}

