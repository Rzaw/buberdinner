namespace BuberDinner.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        ApplicationResult Login(string email, string password);
        ApplicationResult Register(string firstName, string lastName, string email, string password);
    }
}