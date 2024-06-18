using Application.Abstractions.Messaging;

namespace Application.Categories.Commands.UpdateCategory;

public sealed record UpdateCategoryCommand(Guid CategoryId, string Name, string ImagePath) : ICommand<Guid>;
