using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Orders;
using Domain.Products;
using SharedKernel;

namespace Application.Orders.Commands.AddLineItem;

internal sealed class AddLineItemCommandHandler(
    IOrderRepository orderRepository,
    IProductRepository productRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<AddLineItemCommand>
{
    public async Task<Result> Handle(AddLineItemCommand request, CancellationToken cancellationToken)
    {
        var order = await orderRepository.GetByIdAsync(request.OrderId);

        if (order is null)
        {
            return Result.Failure(OrderErrors.NotFound(request.OrderId));
        }

        var product = await productRepository.GetByIdAsync(request.ProductId);

        if (product is null)
        {
            return Result.Failure(ProductErrors.NotFound(request.ProductId));
        }

        order.AddLineItem(product.Id, new Money(request.Currency, request.Amount));

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();

    }
}
