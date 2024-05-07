using Application.Abstractions.Messaging;

namespace Application.Categories.Commands.CreateCategory;

public sealed record CreateCategoryCommand(string Name, string ImagePath) : ICommand<Guid>;
