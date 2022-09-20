namespace BlazorTemplate.IoC;

public static class DependencyContainer
{
    public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        ServiceExtensions.AddDataBase(services, configuration);
        ServiceExtensions.AddIdentity(services);
        ServiceExtensions.ChangeDefaultClaim(services);
        ServiceExtensions.AddAuthentication(services, configuration);
        ServiceExtensions.AddMapper(services);
    }
}