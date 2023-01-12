namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public ApplicationResult Login(string email, string password)
    {
        
        return new ApplicationResult(Guid.NewGuid(), "Hello", "World", email, "token");
    }

    public ApplicationResult Register(string firstName, string lastName, string email, string password)
    {
        return new ApplicationResult(Guid.NewGuid(), firstName, lastName, email, "token");
    }
}
