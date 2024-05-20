using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Customers;
using Domain.Orders;
using SharedKernel;

namespace Application.Orders.Commands.CreateOrder;

internal sealed class CreateOrderCommandHandler(
    ICustomerRepository customerRepository,
    IOrderRepository orderRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<CreateOrderCommand>
{
    public async Task<Result> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var customer = await customerRepository.GetByIdAsync(new CustomerId(request.CustomerId));

        if (customer is null)
        {
            return Result.Failure<Guid>(CustomerErrors.NotFound(request.CustomerId));
        }

        var order = Order.Create(customer.Id);

        await orderRepository.AddAsync(order);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
