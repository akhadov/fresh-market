namespace SharedKernel;

public interface IDateTime
{
    public DateTimeOffset Now => DateTimeOffset.UtcNow;
}
