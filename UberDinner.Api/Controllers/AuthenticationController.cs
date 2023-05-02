using Microsoft.AspNetCore.Mvc;
using UberDinner.Application.Services.Authentication;
using UberDinner.Contracts.Authentication;

namespace UberDinner.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResponse = _authenticationService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        var response = new AuthenticationResponse( 
            authResponse.Id,
            authResponse.FirstName,
            authResponse.LastName,
            authResponse.Email,
            authResponse.Token
        );
        
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResponse = _authenticationService.Login(request.Email, request.Password);
        
        var response = new AuthenticationResponse( 
            authResponse.Id,
            authResponse.FirstName,
            authResponse.LastName,
            authResponse.Email,
            authResponse.Token
        );
        
        return Ok(response);
    }
}