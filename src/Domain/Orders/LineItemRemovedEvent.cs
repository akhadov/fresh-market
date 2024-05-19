﻿using SharedKernel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders;

public record LineItemRemovedEvent(LineItemId LineItemId, OrderId OrderId) : DomainEvent
{
    public static LineItemRemovedEvent Remove(LineItemId lineItemId, OrderId orderId) => new(lineItemId, orderId);
}
