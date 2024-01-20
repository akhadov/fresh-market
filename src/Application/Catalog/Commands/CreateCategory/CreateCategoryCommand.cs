using Application.Common.Interfaces.Messaging;
using Contracts.Catalogs;

namespace Application.Catalog.Commands.CreateCategory;

public sealed class CreateCategoryCommand : ICommand<CategoryResponse>
{
    public string Name { get; set; }

    public string ImagePath { get; set; }
}