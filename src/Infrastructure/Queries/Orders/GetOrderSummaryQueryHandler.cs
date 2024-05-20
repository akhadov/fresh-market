using Application.Abstractions.Messaging;
using Application.Orders.Queries.GetOrderSummary;
using Domain.Orders;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using SharedKernel;

namespace Infrastructure.Queries.Orders;

internal sealed class GetOrderSummaryQueryHandler(ApplicationDbContext context)
    : IQueryHandler<GetOrderSummaryQuery, OrderSummary>
{
    public async Task<Result<OrderSummary>> Handle(GetOrderSummaryQuery request, CancellationToken cancellationToken)
    {
        return await context.OrderSummaries
            .AsNoTracking()
            .FirstOrDefaultAsync(o => o.Id == request.OrderId, cancellationToken);
    }
}
