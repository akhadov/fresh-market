using Domain.Customers;
using SharedKernel.Base;

namespace Domain.Orders;

public record OrderCreatedDomainEvent(OrderId OrderId, CustomerId CustomerId) : DomainEvent
{
    public static OrderCreatedDomainEvent Create(Order order) => new(order.Id, order.CustomerId);
}
