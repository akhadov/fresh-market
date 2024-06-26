﻿using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Orders;
using SharedKernel;

namespace Application.Orders.Commands.RemoveLineItem;

internal sealed class RemoveLineItemCommandHandler(
    IOrderRepository orderRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<RemoveLineItemCommand>
{
    public async Task<Result> Handle(RemoveLineItemCommand request, CancellationToken cancellationToken)
    {
        var order = await orderRepository.GetByIdAsync(new OrderId(request.OrderId), cancellationToken);

        if (order is null)
        {
            return Result.Failure(OrderErrors.NotFound(request.OrderId));
        }

        order.RemoveLineItem(new LineItemId(request.LineItemId));

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
