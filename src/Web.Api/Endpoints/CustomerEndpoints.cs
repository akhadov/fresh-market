using Application.Customers.Create;
using MediatR;
using SharedKernel;
using Web.Api.Extensions;
using Web.Api.Infrastructure;

namespace Web.Api.Endpoints;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("api/customer", async (
            CreateCustomerRequest request,
            ISender sender,
            CancellationToken cancellationToken) =>
        {
            var command = new CreateCustomerCommand(
                request.FirstName,
                request.LastName,
                request.Email);

            Result<Guid> result = await sender.Send(command, cancellationToken);

            return result.Match(Results.Ok, CustomResults.Problem);
        });


    }

}

