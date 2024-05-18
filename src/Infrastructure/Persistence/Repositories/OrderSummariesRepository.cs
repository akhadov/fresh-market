using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
