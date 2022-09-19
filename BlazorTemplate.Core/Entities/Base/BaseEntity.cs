namespace BlazorTemplate.Core.Entities.Base;

public class BaseEntity : EntityId
{
    [ScaffoldColumn(scaffold: false)] public DateTime InsertTime { get; init; } = DateTime.Now;

    [ScaffoldColumn(scaffold: false)] public DateTime UpdateTime { get; init; } = DateTime.Now;

    [ScaffoldColumn(scaffold: false)] public bool IsDeleted { get; init; }
    [ScaffoldColumn(scaffold: false)] public DateTime? DeletedTime { get; init; }
}