using Application.Abstractions.Messaging;
using Domain.Categories;

namespace Application.Categories.Commands.DeleteCategory;

public sealed record DeleteCategoryCommand(CategoryId CategoryId) : ICommand;
