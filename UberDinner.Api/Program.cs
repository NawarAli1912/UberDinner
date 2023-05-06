using UberDinner.Application.Services.Authentication;
using UberDinner.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using UberDinner.Api.Common.Errors;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
    builder.Services.AddInfrastructure(builder.Configuration);
    
    builder.Services.AddControllers();
    
    builder.Services.AddSingleton<ProblemDetailsFactory, UberDinnerProblemDetailsFactory>();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
