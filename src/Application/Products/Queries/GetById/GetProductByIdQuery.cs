using Application.Abstractions.Messaging;
using Domain.Products;

namespace Application.Products.Queries.GetById;

public record GetProductByIdQuery(ProductId ProductId) : IQuery<ProductResponse>;
