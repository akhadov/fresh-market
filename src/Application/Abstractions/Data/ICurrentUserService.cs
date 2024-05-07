namespace Application.Abstractions.Data;

public interface ICurrentUserService
{
    public string? UserId { get; }
}
