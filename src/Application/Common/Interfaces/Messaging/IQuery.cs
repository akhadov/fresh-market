using MediatR;

namespace Application.Common.Interfaces.Messaging;

public interface IQuery<out TResponse> : IRequest<TResponse>
{
}