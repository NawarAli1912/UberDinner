using UberDinner.Application.Common.Authentication;

namespace UberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Login(string email, string password)
    {
        // check if user already exists

        // Create user (generate unique ID)

        // Create JWT Token
        // var token = _jwtTokenGenerator.GenerateToken();

        return new AuthenticationResult(Guid.NewGuid(), "john", "smith", "johnsmith@example.com", "token");
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        var token = _jwtTokenGenerator.GenerateToken(Guid.NewGuid(), firstName, lastName);
        return new AuthenticationResult(Guid.NewGuid(), "john", "smith", "johnsmith@example.com",token);
    }
}
