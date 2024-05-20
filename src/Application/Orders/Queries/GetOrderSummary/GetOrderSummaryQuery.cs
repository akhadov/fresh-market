using Application.Abstractions.Messaging;
using Domain.Orders;


namespace Application.Orders.Queries.GetOrderSummary;

public sealed record GetOrderSummaryQuery(Guid OrderId) : IQuery<OrderSummary?>;

