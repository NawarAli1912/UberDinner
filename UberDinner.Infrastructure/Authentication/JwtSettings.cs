namespace UberDinner.Infrastructure.Authentication;

public class JwtSettings 
{
    public const string NAME = "JwtSettings";
    public string Secret { get; init; } = default!; 

    public int ExpiryMinutes { get; init; }

    public string Issuer { get; init; } = default!; 

    public string Audience { get; init; } = default!;
}