using Application.Abstractions.Messaging;
using Domain.Products;

namespace Application.Products.Commands.DeleteProduct;

public sealed record DeleteProductCommand(ProductId ProductId) : ICommand;
