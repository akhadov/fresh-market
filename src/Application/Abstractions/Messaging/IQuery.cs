using MediatR;
using SharedKernel.Results;

namespace Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}