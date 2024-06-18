using Application.Abstractions.Messaging;

namespace Application.Products.Commands.DeleteProduct;

public sealed record DeleteProductCommand(Guid ProductId) : ICommand;
