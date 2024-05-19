using Domain.Orders;

namespace Infrastructure.Persistence.Repositories;

public class OrderSummariesRepository : IOrderSummaryRepository
{
    private readonly ApplicationDbContext _context;
    public OrderSummariesRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Add(OrderSummary orderSummary)
    {
        _context.OrderSummaries.Add(orderSummary);
    }
}
