using SharedKernel.Base;

namespace Domain.Orders;

public record LineItemCreatedEvent(LineItemId LineItemId, OrderId OrderId) : DomainEvent
{
    public LineItemCreatedEvent(LineItem lineItem) : this(lineItem.Id, lineItem.OrderId) { }

    public static LineItemCreatedEvent Create(LineItem lineItem) => new(lineItem.Id, lineItem.OrderId);
}
