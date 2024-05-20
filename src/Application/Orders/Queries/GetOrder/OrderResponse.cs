namespace Application.Orders.Queries.GetOrder;

public sealed record OrderResponse(Guid Id, Guid CustomerId, List<LineItemResponse> LineItems);
