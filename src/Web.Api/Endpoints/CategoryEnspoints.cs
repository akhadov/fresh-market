using Application.Categories.Commands.CreateCategory;
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
    }
}
