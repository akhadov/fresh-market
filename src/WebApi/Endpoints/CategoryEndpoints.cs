using Application.Categories.Commands.CreateCategory;
using MediatR;
using SharedKernel.Results;
using WebApi.Extensions;
using WebApi.Infrastructure;

namespace WebApi.Endpoints;

public static class CategoryEndpoints
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
