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
    public Task<Result> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
