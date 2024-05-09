using Application.Abstractions.Messaging;
using Domain.Categories;

namespace Application.Categories.Commands.UpdateCategory;

public sealed record UpdateCategoryCommand(CategoryId CategoryId, string Name, string ImagePath) : ICommand<Guid>;
