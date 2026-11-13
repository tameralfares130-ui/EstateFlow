
using EstateFlow.Application.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace EstateFlow.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

        services.AddScoped<IMeterReadingService, MeterReadingService>();

        return services;
    }
}
