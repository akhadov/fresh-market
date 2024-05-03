using MediatR;
using SharedKernel.Results;

namespace Application.Common.Interfaces.Messaging;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}