namespace BlazorTemplate.Core.Entities.Base;

public class EntityId
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [ScaffoldColumn(scaffold: false)]
    public Guid Id { get; init; } = Guid.NewGuid();
}