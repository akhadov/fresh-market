using Application.Abstractions.Messaging;

namespace Application.Categories.Commands.DeleteCategory;

public sealed record DeleteCategoryCommand(Guid CategoryId) : ICommand;
