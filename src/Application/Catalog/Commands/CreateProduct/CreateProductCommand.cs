using Application.Common.Interfaces.Messaging;
using Contracts.Catalogs;

namespace Application.Catalog.Commands.CreateProduct;

public sealed class CreateProductCommand : ICommand<ProductResponse>
{
}