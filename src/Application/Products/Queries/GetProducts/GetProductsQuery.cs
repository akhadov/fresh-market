using Application.Abstractions.Messaging;
using Application.Abstractions.Models;
using Application.Products.Queries.GetById;

namespace Application.Products.Queries.GetProducts;

public sealed record GetProductsQuery(int Page, int PageSize) : IQuery<PagedList<ProductResponse>>;
