using Domain.Customers;
using Domain.Products;
using SharedKernel.Base;

namespace Domain.Orders;

public record OrderId(Guid Value);

public class Order : AggregateRoot<OrderId>
{
    private readonly List<LineItem> _lineItems = new();

    private Order()
    {
    }

    public CustomerId CustomerId { get; private set; }

    public IReadOnlyList<LineItem> LineItems => _lineItems.ToList();

    public static Order Create(CustomerId customerId)
    {
        var order = new Order()
        {
            Id = new OrderId(Guid.NewGuid()),
            CustomerId = customerId,
        };

        order.AddDomainEvent(OrderCreatedEvent.Create(order));

        return order;
    }

    public LineItem AddLineItem(ProductId productId, Money price)
    {
        var lineItem = LineItem.Create(Id, productId, price);

        lineItem.AddDomainEvent(LineItemAddedEvent.Create(lineItem));

        _lineItems.Add(lineItem);

        return lineItem;
    }

    public void RemoveLineItem(LineItemId lineItemId)
    {
        if (HasOneLineItem())
        {
            return;
        }

        var lineItem = _lineItems.FirstOrDefault(li => li.Id == lineItemId);

        if (lineItem is null)
        {
            return;
        }

        _lineItems.Remove(lineItem);

        lineItem.AddDomainEvent(LineItemRemovedEvent.Remove(lineItemId, Id));
    }

    private bool HasOneLineItem() => _lineItems.Count == 1;

}
