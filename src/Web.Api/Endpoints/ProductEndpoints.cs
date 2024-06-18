using Application.Abstractions.Models;
using Application.Products.Commands.CreateProduct;
using Application.Products.Commands.DeleteProduct;
using Application.Products.Commands.UpdateProduct;
using Application.Products.Queries.GetById;
using Application.Products.Queries.GetProducts;
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

        routes.MapGet("api/products/{productId}", async (
            Guid productId,
            ISender sender,
            CancellationToken cancellationToken) =>
        {
            var query = new GetProductByIdQuery(productId);

            Result<ProductResponse> result = await sender.Send(query, cancellationToken);

            return result.Match(Results.Ok, CustomResults.Problem);
        });

        routes.MapGet("api/products", async (
                int page,
                int pageSize,
                ISender sender,
                CancellationToken cancellationToken) =>
        {
            var query = new GetProductsQuery(page, pageSize);

            Result<PagedList<ProductResponse>> result = await sender.Send(query, cancellationToken);

            return result.Match(Results.Ok, CustomResults.Problem);
        });

        routes.MapPut("api/products/{productId}", async (
            Guid productId,
            UpdateProductRequest request,
            ISender sender,
            CancellationToken cancellationToken) =>
        {
            var command = new UpdateProductCommand(
                productId,
                request.CategoryId,
                request.Name,
                request.Sku,
                request.Amount,
                request.Currency
            );

            Result result = await sender.Send(command, cancellationToken);

            return result.Match(Results.NoContent, CustomResults.Problem);
        });

        routes.MapDelete("api/products/{productId}", async (
            Guid productId,
            ISender sender,
            CancellationToken cancellationToken) =>
        {
            var query = new DeleteProductCommand(productId);

            Result result = await sender.Send(query, cancellationToken);

            return result.Match(Results.NoContent, CustomResults.Problem);
        });
    }
}
