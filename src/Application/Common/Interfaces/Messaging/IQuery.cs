using MediatR;
using SharedKernel.Results;

namespace Application.Common.Interfaces.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}