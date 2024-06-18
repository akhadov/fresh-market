using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Categories;
using Domain.Products;
using SharedKernel;

namespace Application.Products.Commands.CreateProduct;

internal sealed class CreateProductCommandHandler(
    IProductRepository productRepository,
    ICategoryRepository categoryRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<CreateProductCommand, Guid>
{
    public async Task<Result<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.GetByIdAsync(new CategoryId(request.CategoryId), cancellationToken);

        if (category is null)
        {
            return Result.Failure<Guid>(CategoryErrors.NotFound(request.CategoryId));
        }

        var price = new Money(request.Currency, request.Amount);

        var sku = Sku.Create(request.Sku);

        var product = Product.Create(request.Name, price, sku!, category.Id);

        await productRepository.AddAsync(product, cancellationToken);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return product.Id.Value;
    }
}
