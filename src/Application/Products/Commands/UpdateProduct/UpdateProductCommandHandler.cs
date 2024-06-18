using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Categories;
using Domain.Products;
using SharedKernel;

namespace Application.Products.Commands.UpdateProduct;

internal sealed class UpdateProductCommandHandler(
    IProductRepository productRepository,
    ICategoryRepository categoryRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<UpdateProductCommand>
{
    public async Task<Result> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(new ProductId(request.ProductId), cancellationToken);

        if (product is null)
        {
            return Result.Failure(ProductErrors.NotFound(request.ProductId));
        }

        var category = await categoryRepository.GetByIdAsync(new CategoryId(request.CategoryId), cancellationToken);

        if (category is null)
        {
            return Result.Failure(CategoryErrors.NotFound(request.CategoryId));
        }

        product.Update(
            new CategoryId(request.CategoryId),
            request.Name,
            new Money(request.Currency, request.Amount),
            Sku.Create(request.Sku)!);

        await productRepository.UpdateAsync(product, cancellationToken);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
