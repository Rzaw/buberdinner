using BuberDinner.Api.Errors;
using BuberDinner.Application;
using BuberDinner.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    // builder.Services.AddControllers(opt => opt.Filters.Add<ErrorHandlingFilterAttribute>());
    builder.Services.AddControllers();
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    builder.Services.AddSingleton<ProblemDetailsFactory, BuberDinnerProblemErrorsFactory>();
}

var app = builder.Build();
{
    // app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
}

app.Run();
