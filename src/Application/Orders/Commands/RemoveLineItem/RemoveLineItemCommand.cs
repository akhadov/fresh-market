using Application.Abstractions.Messaging;
using Domain.Orders;

namespace Application.Orders.Commands.RemoveLineItem;

public sealed record RemoveLineItemCommand(OrderId OrderId, LineItemId LineItemId) : ICommand;
