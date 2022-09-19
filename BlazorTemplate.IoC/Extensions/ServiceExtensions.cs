namespace BlazorTemplate.IoC.Extensions;

public static class ServiceExtensions
{
    public static void AddAuthentication(IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = configuration["JWT:ValidAudience"],
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                };
            });
    }

    public static void ChangeDefaultClaim(IServiceCollection services)
    {
        services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUserClaimsPrincipalFactory>();
    }

    public static void AddIdentity(IServiceCollection services)
    {
        services.AddIdentity<ApplicationUser, ApplicationRole>(option =>
        {
            option.Password.RequireDigit = false;
            option.Password.RequireLowercase = false;
            option.Password.RequireUppercase = false;
            option.Password.RequireNonAlphanumeric = false;
            option.Password.RequiredLength = 4;
        }).AddEntityFrameworkStores<ApplicationDbContext>();
    }

    public static void AddDataBase(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    }
}