namespace BlazorTemplate.Core.Entities.Auth;

public class ApplicationRole : IdentityRole<Guid>
{
    public string? PersianName { get; set; }
}
