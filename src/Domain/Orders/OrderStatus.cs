using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders;

public enum OrderStatus
{
    None = 0,
    PendingPayment = 1,
    ReadyForShipping = 2,
    InTransit = 3
}
