namespace UberDinner.Application.Services.Authentication;

public record AuthenticationResult(
    Guid Id,
    string FirstName, 
    string LastName,
    string Email,
    string Token
);

// Command Count Motions
// Commands: d, c, y, p, v, r, x, u, ctrl + r, i, a, o, ctrl + { 
// Motions: h, j, k, l, w, b