using SharedKernel.Base;

namespace Domain.Orders;

public record LineItemAddedEvent(LineItemId LineItemId, OrderId OrderId) : DomainEvent
{
    public static LineItemAddedEvent Create(LineItem lineItem) => new(lineItem.Id, lineItem.OrderId);
}
