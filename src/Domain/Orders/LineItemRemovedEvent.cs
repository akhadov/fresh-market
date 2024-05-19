using SharedKernel.Base;

namespace Domain.Orders;

public record LineItemRemovedEvent(LineItemId LineItemId, OrderId OrderId) : DomainEvent
{
    public static LineItemRemovedEvent Remove(LineItemId lineItemId, OrderId orderId) => new(lineItemId, orderId);
}
