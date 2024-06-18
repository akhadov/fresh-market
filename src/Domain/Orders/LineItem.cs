using Domain.Products;
using SharedKernel.Base;

namespace Domain.Orders;

public readonly record struct LineItemId(Guid Value);

public class LineItem : AggregateRoot<LineItemId>
{
    private LineItem()
    {
    }
    public OrderId OrderId { get; private set; }

    public ProductId ProductId { get; private set; }

    public Money Price { get; private set; }

    internal static LineItem Create(OrderId orderId, ProductId productId, Money price)
    {
        return new LineItem
        {
            Id = new LineItemId(Guid.NewGuid()),
            OrderId = orderId,
            ProductId = productId,
            Price = price
        };
    }
}
