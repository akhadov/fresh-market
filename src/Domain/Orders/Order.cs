﻿using Domain.Customers;
using Domain.Products;
using SharedKernel;
using SharedKernel.Base;
using SharedKernel.Entities;
using SharedKernel.Exceptions;
using System;

namespace Domain.Orders;

public class Order : AggregateRoot<OrderId>
{
    private readonly List<LineItem> _lineItems = new();

    public IEnumerable<LineItem> LineItems => _lineItems.AsReadOnly();

    public required CustomerId CustomerId { get; init; }

    public Customer? Customer { get; set; }

    public Money AmountPaid { get; private set; } = null!;

    public OrderStatus Status { get; private set; }

    public DateTimeOffset ShippingDate { get; private set; }

    public Currency? OrderCurrency => _lineItems.FirstOrDefault()?.Price.Currency;

    public Money OrderTotal
    {
        get
        {
            if (_lineItems.Count == 0)
                return Money.Default;

            var amount = _lineItems.Sum(li => li.Price.Amount * li.Quantity);
            var currency = _lineItems[0].Price.Currency;

            return new Money(currency, amount);
        }
    }

    private Order() { }

    public static Order Create(CustomerId customerId)
    {
        var order = new Order()
        {
            Id = new OrderId(Guid.NewGuid()),
            CustomerId = customerId,
            AmountPaid = Money.Default,
            Status = OrderStatus.PendingPayment
        };

        order.AddDomainEvent(OrderCreatedDomainEvent.Create(order));

        return order;
    }

    public LineItem AddLineItem(ProductId productId, Money price, int quantity)
    {
        Guard.Against.Condition(Status != OrderStatus.PendingPayment, "Can't modify order once payment is done");

        if (OrderCurrency != null && OrderCurrency != price.Currency)
            throw new DomainException($"Cannot add line item with currency {price.Currency} to and order than already contains a currency of {price.Currency}");

        var existingLineItem = _lineItems.FirstOrDefault(li => li.ProductId == productId);
        if (existingLineItem != null)
        {
            existingLineItem.AddQuantity(quantity);
            return existingLineItem;
        }

        var lineItem = LineItem.Create(Id, productId, price, quantity);
        AddDomainEvent(new LineItemCreatedDomainEvent(lineItem.Id, lineItem.OrderId));
        _lineItems.Add(lineItem);

        return lineItem;
    }

    public void RemoveLineItem(ProductId productId)
    {
        Guard.Against.Condition(Status != OrderStatus.PendingPayment, "Can't modify order once payment is done");

        var lineItem = _lineItems.RemoveAll(x => x.ProductId == productId);
    }

    public void AddPayment(Money payment)
    {
        Guard.Against.ZeroOrNegative(payment.Amount);
        Guard.Against.Condition(payment > OrderTotal - AmountPaid, "Payment can't exceed order total");

        // Ensure currency is set on first payment
        if (AmountPaid.Amount == 0)
            AmountPaid = payment;
        else
            AmountPaid += payment;

        if (AmountPaid >= OrderTotal)
        {
            Status = OrderStatus.ReadyForShipping;
            AddDomainEvent(new OrderReadyForShippingEvent(Id));
        }
    }

    public void AddQuantity(ProductId productId, int quantity) =>
        _lineItems.FirstOrDefault(li => li.ProductId == productId)?.AddQuantity(quantity);

    public void RemoveQuantity(ProductId productId, int quantity) =>
        _lineItems.FirstOrDefault(li => li.ProductId == productId)?.RemoveQuantity(quantity);

    public void ShipOrder(IDateTime dateTime)
    {
        Guard.Against.Condition(_lineItems.Sum(li => li.Quantity) <= 0, "Can't ship an order with no items");
        Guard.Against.Condition(Status == OrderStatus.PendingPayment, "Can't ship an unpaid order");
        Guard.Against.Condition(Status == OrderStatus.InTransit, "Order already shipped to customer");

        ShippingDate = dateTime.Now;
        Status = OrderStatus.InTransit;
    }
}
