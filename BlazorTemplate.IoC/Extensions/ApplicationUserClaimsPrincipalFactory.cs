namespace BlazorTemplate.IoC.Extensions;

public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, ApplicationRole>
{
    public ApplicationUserClaimsPrincipalFactory(UserManager<ApplicationUser> userManager,
        RoleManager<ApplicationRole> roleManager,
        IOptions<IdentityOptions> optionsAccessor) :
        base(userManager,
        roleManager,
        optionsAccessor)
    {
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
    {
        var identity = await base.GenerateClaimsAsync(user);
        identity.AddClaim(new Claim("UserId", user.Id.ToString() ?? "کاربری یافت نشد"));
        identity.AddClaim(new Claim("FullName", $"{user.Name} {user.Family}" ?? "کاربری یافت نشد"));
        return identity;
    }
}
