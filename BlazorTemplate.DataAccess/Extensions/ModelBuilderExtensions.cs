namespace BlazorTemplate.DataAccess.Extensions;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationUser>(b =>
        {
            b.ToTable("Users");
        });

        modelBuilder.Entity<IdentityUserClaim<Guid>>(b =>
        {
            b.ToTable("UserClaims");
        });

        modelBuilder.Entity<IdentityUserLogin<Guid>>(b =>
        {
            b.ToTable("UserLogins");
        });

        modelBuilder.Entity<IdentityUserToken<Guid>>(b =>
        {
            b.ToTable("UserTokens");
        });

        modelBuilder.Entity<ApplicationRole>(b =>
        {
            b.ToTable("Roles");
        });

        modelBuilder.Entity<IdentityRoleClaim<Guid>>(b =>
        {
            b.ToTable("RoleClaims");
        });

        modelBuilder.Entity<IdentityUserRole<Guid>>(b =>
        {
            b.ToTable("UserRoles");
        });
    }
}
