using Application.Products.Commands.CreateProduct;
using MediatR;
using SharedKernel;
using Web.Api.Extensions;
using Web.Api.Infrastructure;

namespace Web.Api.Endpoints;

public static class ProductEndpoints
{
    public static void MapProductEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("api/products", async (
            CreateProductRequest request,
            ISender sender,
            CancellationToken cancellationToken) =>
        {
            var command = new CreateProductCommand(
                request.Name,
                request.Sku,
                request.Amount,
                request.Currency,
                request.CategoryId);

            Result<Guid> result = await sender.Send(command, cancellationToken);

            return result.Match(Results.Ok, CustomResults.Problem);

        });
    }
}
