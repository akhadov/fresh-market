using Application.Abstractions.Messaging;
using Microsoft.AspNetCore.Http;

namespace Application.Categories.Commands.CreateCategory;

public sealed record CreateCategoryCommand(string Name, IFormFile Image) : ICommand<Guid>;
