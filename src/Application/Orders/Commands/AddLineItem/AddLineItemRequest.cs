namespace Application.Orders.Commands.AddLineItem;

public sealed record AddLineItemRequest(
    Guid ProductId, string Currency, decimal Amount);
