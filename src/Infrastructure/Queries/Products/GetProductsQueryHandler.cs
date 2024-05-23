using Application.Abstractions.Messaging;
using Application.Abstractions.Models;
using Application.Products.Queries.GetById;
using Application.Products.Queries.GetProducts;
using Infrastructure.Persistence;
using SharedKernel;

namespace Infrastructure.Queries.Products;

internal sealed class GetProductsQueryHandler(ApplicationDbContext context)
    : IQueryHandler<GetProductsQuery, PagedList<ProductResponse>>
{
    public async Task<Result<PagedList<ProductResponse>>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        IQueryable<ProductResponse> productsQuery = context.Products
                .Select(p => new ProductResponse
                {
                    Id = p.Id,
                    Name = p.Name,
                    Sku = p.Sku.Value,
                    Currency = p.Price.Currency,
                    Amount = p.Price.Amount
                });

        var products = await PagedList<ProductResponse>.CreateAsync(productsQuery, request.Page, request.PageSize);

        return products;
    }
}
