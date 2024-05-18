using SharedKernel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders;

public record LineItemRemovedDomainEvent(LineItemId LineItemId, OrderId OrderId) : DomainEvent
{
    public static LineItemRemovedDomainEvent Remove(LineItemId lineItemId, OrderId orderId) => new(lineItemId, orderId);
}
