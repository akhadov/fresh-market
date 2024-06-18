using Application.Orders.Commands.AddLineItem;
using Application.Orders.Commands.CreateOrder;
using Application.Orders.Commands.RemoveLineItem;
using Application.Orders.Queries.GetOrder;
using MediatR;
using SharedKernel;
using Web.Api.Extensions;
using Web.Api.Infrastructure;

namespace Web.Api.Endpoints;

public static class OrderEndpoints
{
    public static void MapOrderEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("api/orders", async (
            CreateOrderCommand request,
            ISender sender,
            CancellationToken cancellationToken) =>
        {
            var command = new CreateOrderCommand(request.CustomerId);

            Result result = await sender.Send(command, cancellationToken);

            return result.Match(Results.NoContent, CustomResults.Problem);
        });

        routes.MapPut("api/orders/{orderId}/line-items", async (
            Guid orderId,
            AddLineItemRequest request,
            ISender sender,
            CancellationToken cancellationToken) =>
        {
            var command = new AddLineItemCommand(
                orderId,
                request.ProductId,
                request.Currency,
                request.Amount);

            Result result = await sender.Send(command, cancellationToken);

            return result.Match(Results.NoContent, CustomResults.Problem);
        });

        routes.MapGet("api/orders/{orderId}", async (
            Guid orderId,
            ISender sender,
            CancellationToken cancellationToken) =>
        {
            var query = new GetOrderQuery(orderId);

            Result<OrderResponse> result = await sender.Send(query, cancellationToken);

            return result.Match(Results.Ok, CustomResults.Problem);
        });

        routes.MapDelete("api/orders/{orderId}/line-items/{lineItemId}", async (
            Guid orderId,
            Guid lineItemId,
            ISender sender,
            CancellationToken cancellationToken) =>
        {
            var command = new RemoveLineItemCommand(
                orderId,
                lineItemId);

            Result result = await sender.Send(command, cancellationToken);

            return result.Match(Results.NoContent, CustomResults.Problem);
        });

    }
}
