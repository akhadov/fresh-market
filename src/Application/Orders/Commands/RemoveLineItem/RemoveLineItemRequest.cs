namespace Application.Orders.Commands.RemoveLineItem;

public sealed record RemoveLineItemRequest(Guid OrderId, Guid LineItemId);
