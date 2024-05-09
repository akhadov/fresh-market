namespace Application.Abstractions;

public interface ICurrentUserService
{
    public string? UserId { get; }
}
