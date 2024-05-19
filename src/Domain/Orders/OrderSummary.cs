using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders;

public record OrderSummary(
    Guid Id,
    Guid CustomerId,
    string CustomerFirstName,
    decimal TotalPrice,
    List<OrderSummary.LineItem> LineItems)
{
    public record LineItem(
        Guid Id,
        Guid ProductId,
        string ProductName,
        string ProductSku,
        decimal PriceAmount,
        string PriceCurrency);
}