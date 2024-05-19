using Application.Orders.Commands.CreateOrder;
using Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Services;

internal sealed class CalculateOrderSummary : ICalculateOrderSummary
{
    private readonly ApplicationDbContext _context;

    public CalculateOrderSummary(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<OrderSummary?> CalculateAsync(OrderId orderId)
    {
        var orderSummaryData =
            from order in _context.Orders
            join customer in _context.Customers on order.CustomerId equals customer.Id
            join lineItem in _context.LineItems on order.Id equals lineItem.OrderId
            join product in _context.Products on lineItem.ProductId equals product.Id
            where order.Id == orderId
            select new
            {
                OrderId = order.Id.Value,
                CustomerId = customer.Id.Value,
                CustomerName = customer.FirstName,
                LineItemId = lineItem.Id.Value,
                PriceAmount = lineItem.Price.Amount,
                PriceCurrency = lineItem.Price.Currency,
                ProductId = product.Id.Value,
                ProductName = product.Name,
                ProductSku = product.Sku.Value
            };

        var orderSummaries = await orderSummaryData.ToListAsync();

        var orderSummary = orderSummaries
            .GroupBy(os => os.OrderId)
            .Select(g => new OrderSummary(
                g.Key,
                g.First().CustomerId,
                g.First().CustomerName.Value,
                g.Sum(os => os.PriceAmount),
                g.Select(os => new OrderSummary.LineItem(
                        os.LineItemId,
                        os.ProductId,
                        os.ProductName,
                        os.ProductSku,
                        os.PriceAmount,
                        os.PriceCurrency))
                    .ToList()))
            .FirstOrDefault();

        return orderSummary;
    }
}
