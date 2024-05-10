using Application.Abstractions.Messaging;

namespace Application.Products.Commands.CreateProduct;

public sealed record CreateProductCommand(string Name, string Sku, decimal Amount, string Currency, Guid CategoryId) : ICommand<Guid>;
