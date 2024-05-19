using Application.Abstractions.Messaging;
using Domain.Orders;
using Domain.Products;

namespace Application.Orders.Commands.AddLineItem;

public sealed record AddLineItemCommand(
    OrderId OrderId, ProductId ProductId, string Currency, decimal Amount) : ICommand;
