using Application.Abstractions.Messaging;
using Domain.Categories;
using Domain.Products;

namespace Application.Products.Commands.UpdateProduct;

public sealed record UpdateProductCommand(ProductId ProductId, CategoryId CategoryId, string Name, string Sku, decimal Amount, string Currency) : ICommand<Guid>;
