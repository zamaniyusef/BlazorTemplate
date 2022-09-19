var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");

builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(_ => new HttpClient {
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
});

builder.Services.AddMudServices();

await builder.Build().RunAsync();