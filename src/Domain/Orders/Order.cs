using Domain.Customers;
using Domain.Products;
using SharedKernel;
using SharedKernel.Base;

namespace Domain.Orders;

public class Order : AggregateRoot<OrderId>
{
    private readonly List<LineItem> _lineItems = new();

    public IEnumerable<LineItem> LineItems => _lineItems.AsReadOnly();

    public required CustomerId CustomerId { get; init; }

    public OrderStatus Status { get; private set; }

    public DateTimeOffset ShippingDate { get; private set; }


    private Order() { }

    public static Order Create(CustomerId customerId)
    {
        var order = new Order()
        {
            Id = new OrderId(Guid.NewGuid()),
            CustomerId = customerId,
            Status = OrderStatus.PendingPayment
        };

        order.AddDomainEvent(OrderCreatedEvent.Create(order));

        return order;
    }

    public LineItem AddLineItem(ProductId productId, Money price, int quantity)
    {
        var lineItem = LineItem.Create(Id, productId, price, quantity);
        AddDomainEvent(new LineItemAddedEvent(lineItem.Id, lineItem.OrderId));
        _lineItems.Add(lineItem);

        return lineItem;
    }

    public void RemoveLineItem(ProductId productId)
    {
        var lineItem = _lineItems.RemoveAll(x => x.ProductId == productId);
    }


    public void AddQuantity(ProductId productId, int quantity) =>
        _lineItems.FirstOrDefault(li => li.ProductId == productId)?.AddQuantity(quantity);

    public void RemoveQuantity(ProductId productId, int quantity) =>
        _lineItems.FirstOrDefault(li => li.ProductId == productId)?.RemoveQuantity(quantity);

    public void ShipOrder(IDateTimeProvider dateTimeProvider)
    {

        ShippingDate = dateTimeProvider.UtcNow;
        Status = OrderStatus.InTransit;
    }
}

