using Application.Abstractions.Messaging;

namespace Application.Orders.Queries.GetOrder;

public sealed record GetOrderQuery(Guid OrderId) : IQuery<OrderResponse>;
