namespace SharedKernel.Interfaces;

public interface IAuditable
{
    public DateTimeOffset CreatedAt { get; }
    public string? CreatedBy { get; }
    public DateTimeOffset? UpdatedAt { get; }
    public string? UpdatedBy { get; }

    public void SetCreated(DateTimeOffset createdAt, string? createdBy);

    public void SetUpdated(DateTimeOffset updatedAt, string? updatedBy);
}
