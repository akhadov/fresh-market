using Domain.Products;
using SharedKernel.Base;

namespace Domain.Orders;

public class LineItem : AggregateRoot<LineItemId>
{
    internal LineItem(LineItemId id, OrderId orderId, ProductId productId, Money price)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }

    private LineItem()
    {
    }
    public OrderId OrderId { get; private set; }

    public ProductId ProductId { get; private set; }

    public Money Price { get; private set; }

}

