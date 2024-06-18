using Application.Abstractions.Messaging;
using Application.Orders.Queries.GetOrder;
using Domain.Orders;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using SharedKernel;

namespace Infrastructure.Queries.Orders;

internal sealed class GetOrderQueryHandler(ApplicationDbContext context)
    : IQueryHandler<GetOrderQuery, OrderResponse>
{
    public async Task<Result<OrderResponse>> Handle(GetOrderQuery request, CancellationToken cancellationToken)
    {
        var orderId = new OrderId(request.OrderId);

        var orderResponse = await context
            .Orders
            .Where(o => o.Id == orderId)
            .Select(o => new OrderResponse(
                o.Id.Value,
                o.CustomerId.Value,
                o.LineItems
                    .Select(li => new LineItemResponse(li.Id.Value, li.Price.Amount))
                    .ToList()))
            .FirstOrDefaultAsync(cancellationToken);

        if (orderResponse is null)
        {
            return Result.Failure<OrderResponse>(OrderErrors.NotFound(request.OrderId));
        }

        return orderResponse;
    }
}
