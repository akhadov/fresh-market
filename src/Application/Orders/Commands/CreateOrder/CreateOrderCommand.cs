using Application.Abstractions.Messaging;
using Domain.Customers;

namespace Application.Orders.Commands.CreateOrder;

public sealed record CreateOrderCommand(CustomerId CustomerId) : ICommand;
