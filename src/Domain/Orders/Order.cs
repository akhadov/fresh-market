using Domain.Customers;
using SharedKernel.Base;

namespace Domain.Orders;

public class Order : AggregateRoot<OrderId>
{
    private readonly List<LineItem> _lineItems = new();

    public IEnumerable<LineItem> LineItems => _lineItems.AsReadOnly();

    public required CustomerId CustomerId { get; init; }

    public Customer? Customer { get; set; }
    private Order() { }
}
