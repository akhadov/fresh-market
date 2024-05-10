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
        var categoryId = new CategoryId(request.CategoryId);

        var price = new Money(request.Currency, request.Amount);

        var sku = Sku.Create(request.Sku);

        var product = Product.Create(request.Name, price, sku!, categoryId);

        await productRepository.AddAsync(product);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return product.Id.Value;
    }
}
