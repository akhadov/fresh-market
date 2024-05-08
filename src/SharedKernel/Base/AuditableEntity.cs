using SharedKernel.Interfaces;

namespace SharedKernel.Base;

public abstract class AuditableEntity : IAuditableEntity
{
    public DateTimeOffset CreatedAt { get; private set; }
    public string? CreatedBy { get; private set; }
    public DateTimeOffset? UpdatedAt { get; private set; }
    public string? UpdatedBy { get; private set; }

    public void SetCreated(DateTimeOffset createdAt, string? createdBy)
    {
        CreatedAt = createdAt;
        CreatedBy = createdBy;
    }

    public void SetUpdated(DateTimeOffset updatedAt, string? updatedBy)
    {
        UpdatedAt = updatedAt;
        UpdatedBy = updatedBy;
    }
}