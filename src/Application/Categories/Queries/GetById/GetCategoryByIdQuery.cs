using Application.Abstractions.Messaging;
using Domain.Categories;

namespace Application.Categories.Queries.GetById;

public sealed record GetCategoryByIdQuery(CategoryId CategoryId) : IQuery<CategoryResponse>;
