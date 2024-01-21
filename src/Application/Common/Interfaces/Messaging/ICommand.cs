using MediatR;

namespace Application.Common.Interfaces.Messaging;

public interface ICommand : IRequest<long> {}

public interface ICommand<out TResponse> : IRequest<TResponse> {}