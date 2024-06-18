using Domain.Customers;
using SharedKernel.Base;

namespace Domain.Orders;

public record OrderCreatedEvent(OrderId OrderId, CustomerId CustomerId) : DomainEvent
{
    public static OrderCreatedEvent Create(Order order) => new(order.Id, order.CustomerId);
}