using Domain.Orders;

namespace Application.Orders.Commands.CreateOrder;

public interface ICalculateOrderSummary
{
    Task<OrderSummary?> CalculateAsync(OrderId orderId);
}