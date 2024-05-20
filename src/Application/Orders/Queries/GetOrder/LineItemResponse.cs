namespace Application.Orders.Queries.GetOrder;

public sealed record LineItemResponse(Guid LineItemId, decimal Price);
