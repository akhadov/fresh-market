using Application.Common.Interfaces.Messaging;
using Contracts.Catalogs;
using Domain.Categories;

namespace Application.Catalog.Commands.CreateProduct;

public sealed class CreateProductCommand : ICommand<ProductResponse>
{
    public string Name { get; set; }

    public string ImagePath { get; set; }

    public string Title { get; set; }

    public decimal Price { get; set; }

    public long CategoryId { get; set; }
    public Category? Category { get; set; }
}