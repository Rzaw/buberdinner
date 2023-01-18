using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRespository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRespository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRespository = userRespository;
    }

    public ApplicationResult Login(string email, string password)
    {
        // Validate that user exists
        if (_userRespository.GetUserByEmail(email) is not User user)
            throw new Exception("User with given email/password does not exist");

        // Password is good
        if (user.Password != password)
            throw new Exception("Invalid password");
        
        // Create token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new ApplicationResult(user, token);
    }

    public ApplicationResult Register(string firstName, string lastName, string email, string password)
    {
        // Validate the user doesn't exist
        if (_userRespository.GetUserByEmail(email) is not null)
            throw new Exception("User with a given email already exists");

        // Create user (generate unique ID)
        var user = new User()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };

        _userRespository.Add(user);

        // Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new ApplicationResult(user, token);
    }
}
