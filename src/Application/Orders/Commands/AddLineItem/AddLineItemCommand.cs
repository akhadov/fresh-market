using Application.Abstractions.Messaging;

namespace Application.Orders.Commands.AddLineItem;

public sealed record AddLineItemCommand(
    Guid OrderId, Guid ProductId, string Currency, decimal Amount) : ICommand;
