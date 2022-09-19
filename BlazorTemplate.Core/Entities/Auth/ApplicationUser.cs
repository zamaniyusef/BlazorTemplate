namespace BlazorTemplate.Core.Entities.Auth;

public class ApplicationUser : IdentityUser<Guid>
{
    public string? Name { get; set; }
    public string? Family { get; set; }
}
