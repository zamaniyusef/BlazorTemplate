namespace Authentication.Client.Interfaces;

public interface IAuthenticationService
{
    Task<RegistrationResponseViewModel> RegisterUser(RegisterViewModel model);
}