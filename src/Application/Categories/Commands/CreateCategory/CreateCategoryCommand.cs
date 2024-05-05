using Application.Abstractions.Messaging;

namespace Application.Categories.Commands.CreateCategory;

public sealed record CreateCategoryCommand(string Name) : ICommand<Guid>;
