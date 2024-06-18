using Application.Abstractions.Messaging;

namespace Application.Products.Commands.UpdateProduct;

public sealed record UpdateProductCommand(Guid ProductId, Guid CategoryId, string Name, string Sku, decimal Amount, string Currency) : ICommand;
