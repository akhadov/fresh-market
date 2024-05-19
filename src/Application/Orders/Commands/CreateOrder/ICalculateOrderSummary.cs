using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Commands.CreateOrder;

public interface ICalculateOrderSummary
{
    Task<OrderSummary?> CalculateAsync(OrderId orderId);
}