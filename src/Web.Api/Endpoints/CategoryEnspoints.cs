using Application.Categories.Commands.CreateCategory;
using Application.Categories.Commands.DeleteCategory;
using Application.Categories.Commands.UpdateCategory;
using Application.Categories.Queries.GetById;
using MediatR;
using SharedKernel;
using Web.Api.Extensions;
using Web.Api.Infrastructure;

namespace Web.Api.Endpoints;

public static class CategoryEnspoints
{
    public static void MapCategoryEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("api/categories", async (
            CreateCategoryRequest request,
            ISender sender,
            CancellationToken cancellationToken) =>
        {

            var command = new CreateCategoryCommand(
                request.Name,
                request.ImagePath);

            Result<Guid> result = await sender.Send(command, cancellationToken);

            return result.Match(Results.Ok, CustomResults.Problem);

        });

        routes.MapGet("api/categories/{categoryId}", async (
            Guid categoryId,
            ISender sender,
            CancellationToken cancellationToken) =>
        {
            var query = new GetCategoryByIdQuery(categoryId);

            Result<CategoryResponse> result = await sender.Send(query, cancellationToken);

            return result.Match(Results.Ok, CustomResults.Problem);
        });

        routes.MapPut("api/categories/{categoryId}", async (
                Guid categoryId,
                UpdateCategoryRequest request,
                ISender sender,
                CancellationToken cancellationToken) =>
        {
            var command = new UpdateCategoryCommand(
                categoryId,
                request.Name,
                request.ImagePath);

            Result result = await sender.Send(command, cancellationToken);

            return result.Match(Results.NoContent, CustomResults.Problem);
        });

        routes.MapDelete("api/categories/{categoryId}", async (
                Guid categoryId,
                ISender sender,
                CancellationToken cancellationToken) =>
        {
            var query = new DeleteCategoryCommand(categoryId);

            Result result = await sender.Send(query, cancellationToken);

            return result.Match(Results.NoContent, CustomResults.Problem);
        });

    }
}
