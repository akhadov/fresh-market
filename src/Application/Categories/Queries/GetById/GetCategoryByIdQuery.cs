using Application.Abstractions.Messaging;

namespace Application.Categories.Queries.GetById;

public sealed record GetCategoryByIdQuery(Guid CategoryId) : IQuery<CategoryResponse>;
