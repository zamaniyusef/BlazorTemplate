namespace BlazorTemplate.Core.Entities.Base;

public class BaseEntityIsActive : BaseEntity
{
    public bool IsActive { get; init; }
    public DateTime ActiveDate { get; init; } = DateTime.Now;
}