using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UberDinner.Application.Common.Authentication;
using UberDinner.Application.Common.Services;
using UberDinner.Infrastructure.Authentication;
using UberDinner.Infrastructure.Services;

namespace UberDinner.Infrastructure;

public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.NAME));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;
    }
}