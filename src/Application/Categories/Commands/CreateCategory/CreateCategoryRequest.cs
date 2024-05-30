using Microsoft.AspNetCore.Http;

namespace Application.Categories.Commands.CreateCategory;

public sealed record CreateCategoryRequest(string Name, IFormFile Image);
