﻿using Domain.Customers;
using Domain.Products;
using SharedKernel;
using SharedKernel.Base;

namespace Domain.Orders;

public class Order : AggregateRoot<OrderId>
{
    private readonly List<LineItem> _lineItems = new();

    private Order()
    {
    }

    public required CustomerId CustomerId { get; init; }

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

    public void AddLineItem(ProductId productId, Money price)
    {
        var lineItem = new LineItem(
            new LineItemId(Guid.NewGuid()),
            Id,
            productId,
            price);

        _lineItems.Add(lineItem);

        lineItem.AddDomainEvent(LineItemAddedEvent.Create(lineItem));
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

