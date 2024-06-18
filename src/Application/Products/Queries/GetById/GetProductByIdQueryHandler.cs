using Application.Abstractions.Messaging;
using Domain.Products;
using SharedKernel;

namespace Application.Products.Queries.GetById;

internal sealed class GetProductByIdQueryHandler(
    IProductRepository productRepository) : IQueryHandler<GetProductByIdQuery, ProductResponse>
{
    public async Task<Result<ProductResponse>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(new ProductId(request.ProductId), cancellationToken);

        if (product is null)
        {
            return Result.Failure<ProductResponse>(ProductErrors.NotFound(request.ProductId));
        }

        var productResponse = new ProductResponse
        {
            Id = product.Id.Value,
            Name = product.Name,
            Sku = product.Sku.Value,
            Currency = product.Price.Currency,
            Amount = product.Price.Amount,
        };

        return Result.Success(productResponse);
    }
}
