using SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders;

public interface IOrderSummaryRepository
{
    void Add(OrderSummary orderSummary);
}
