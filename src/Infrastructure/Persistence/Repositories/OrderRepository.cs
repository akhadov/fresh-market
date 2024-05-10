using Domain.Orders;

namespace Infrastructure.Persistence.Repositories;

public class OrderRepository : Repository<Order, OrderId>, IOrderRepository
{
    private readonly ApplicationDbContext context;

    public OrderRepository(ApplicationDbContext context) : base(context)
    {
        this.context = context;
    }
}
