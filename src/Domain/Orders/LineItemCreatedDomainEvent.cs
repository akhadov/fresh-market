using SharedKernel.Base;

namespace Domain.Orders;

public record LineItemCreatedDomainEvent(LineItemId LineItemId, OrderId OrderId) : DomainEvent
{
    public LineItemCreatedDomainEvent(LineItem lineItem) : this(lineItem.Id, lineItem.OrderId) { }

    public static LineItemCreatedDomainEvent Create(LineItem lineItem) => new(lineItem.Id, lineItem.OrderId);
}
