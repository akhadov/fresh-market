using Application.Abstractions.Messaging;
using SharedKernel.Results;

namespace Application.Categories.Commands.CreateCategory;

internal sealed class CreateCategoryCommandHandler : ICommandHandler<CreateCategoryCommand, Guid>
{
    public Task<Result<Guid>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
