using Application.Abstractions.Messaging;

namespace Application.Orders.Commands.CreateOrder;

public sealed record CreateOrderCommand(Guid CustomerId) : ICommand;
