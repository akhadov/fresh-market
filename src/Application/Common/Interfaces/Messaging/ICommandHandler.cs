using MediatR;

namespace Application.Common.Interfaces.Messaging;

public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, long>
    where TCommand : ICommand
{
}

public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
{
}