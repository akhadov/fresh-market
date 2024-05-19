namespace Domain.Orders;

public interface IOrderSummaryRepository
{
    void Add(OrderSummary orderSummary);
}
