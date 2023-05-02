namespace UberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "john", "smith", "johnsmith@example.com", "token");
    }

    public AuthenticationResult Register(string firstName, string LastName, string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "john", "smith", "johnsmith@example.com", "token");
    }
}
