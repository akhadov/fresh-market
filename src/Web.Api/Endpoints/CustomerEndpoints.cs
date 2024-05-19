using MediatR;

namespace Web.Api.Endpoints;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("api/customers/{customerId}", async (
            Guid customerId,
            ISender sender,
            CancellationToken cancellationToken) =>
        {
            //var query = new GetCustomerByIdQuery(new CustomerId(customerId));
        });
    }

}
      
