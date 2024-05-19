using MediatR;
using SharedKernel;

namespace Web.Api.Endpoints;

public static class OrderEndpoints
{
    public static void MapOrderEndpoints(this IEndpointRouteBuilder routes)
    {
        //routes.MapPost("api/orders", async (
        //    CreateOrderRequest request,
        //    ISender sender,
        //    CancellationToken cancellationToken) =>
        //{
        //    var command = new CreateOrderCommand(
        //        request.CustomerId,
        //        request.ProductId,
        //        request.Amount,
        //        request.Currency);

        //    Result<Guid> result = await sender.Send(command, cancellationToken);

        //    return result.Match(Results.Ok, CustomResults.Problem);
        //});

        //routes.MapGet("api/orders/{orderId}", async (
        //    Guid orderId,
        //    ISender sender,
        //    CancellationToken cancellationToken) =>
        //{
        //    var query = new GetOrderByIdQuery(new OrderId(orderId));

        //    Result<OrderResponse> result = await sender.Send(query, cancellationToken);

        //    return result.Match(Results.Ok, CustomResults.Problem);
        //});

        //routes.MapPut("api/orders/{orderId}", async (
        //    Guid orderId,
        //    UpdateOrderRequest request,
        //    ISender sender,
        //    CancellationToken cancellationToken) =>
        //{
        //    var command = new UpdateOrderCommand(
        //        new OrderId(orderId),
        //        request.CustomerId,
        //        request.ProductId,
        //        request.Amount,
        //        request.Currency);

        //    Result result = await sender.Send(command, cancellationToken);

        //    return result.Match(Results.Ok, CustomResults.Problem);
        //});

        //routes.MapDelete("api/orders/{orderId}", async (
        //    Guid orderId,
        //    ISender sender,
        //    CancellationToken cancellationToken) =>
        //{
        //    var command = new DeleteOrderCommand(new OrderId(orderId));

        //    Result result = await sender.Send(command, cancellationToken);

        //    return result.Match(Results.Ok, CustomResults.Problem);
        //});

    }
}
