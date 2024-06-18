using Application.Abstractions.Messaging;

namespace Application.Orders.Commands.RemoveLineItem;

public sealed record RemoveLineItemCommand(Guid OrderId, Guid LineItemId) : ICommand;
