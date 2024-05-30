using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Products;
using SharedKernel;

namespace Application.Products.Commands.UpdateProduct;

internal sealed class UpdateProductCommandHandler(
    IProductRepository productRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<UpdateProductCommand, Guid>
{
    public async Task<Result<Guid>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(request.ProductId);

        if (product is null)
        {
            return Result.Failure<Guid>(ProductErrors.NotFound(request.ProductId));
        }

        product.Update(
            request.Name,
            new Money(request.Currency, request.Amount),
            Sku.Create(request.Sku)!);

        await productRepository.UpdateAsync(product);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return product.Id.Value;
    }
}
