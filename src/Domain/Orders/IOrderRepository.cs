using SharedKernel.Interfaces;

namespace Domain.Orders;

public interface IOrderRepository : IRepository<Order, OrderId>
{
}
