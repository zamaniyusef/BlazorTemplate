using System.Text;
using System.Text.Json;
using Authentication.Client.Interfaces;
using BlazorTemplate.Shared.Models;

namespace Authentication.Client.Services;

public class AuthenticationService: IAuthenticationService
{
    private readonly HttpClient _client;
    private readonly JsonSerializerOptions? _options;
    
    public AuthenticationService(HttpClient client)
    {
        _client = client;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }
    
    public async Task<RegistrationResponseViewModel> RegisterUser(RegisterViewModel model)
    {
        var content = JsonSerializer.Serialize(model);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
        var registrationResult = await _client.PostAsync("api/Accounts/Register", bodyContent);
        var registrationContent = await registrationResult.Content.ReadAsStringAsync();
        return !registrationResult.IsSuccessStatusCode ? 
            JsonSerializer.Deserialize<RegistrationResponseViewModel>(registrationContent, _options) :
            new RegistrationResponseViewModel { IsSuccessfulRegistration = true };
    }
}