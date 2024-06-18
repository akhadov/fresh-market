using Application.Abstractions.Messaging;

namespace Application.Products.Queries.GetById;

public record GetProductByIdQuery(Guid ProductId) : IQuery<ProductResponse>;
