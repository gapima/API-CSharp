using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlanBia.Application.Interfaces;
using PlanBia.Application.Mappings;
using PlanBia.Application.Services;
using Siderum.Infra.Context;
using Siderum.Infra.Interfaces;
using Siderum.Infra.Repositories;

namespace PlanBia.IoC;

public static class DependencyInjection
{
    public static IServiceCollection RegisterApps(this IServiceCollection services)
    {
        // Registrando o Contexto
        services.AddDbContext<SiderumContext>();

        // Repositories
        services.AddScoped<IClienteRepository, ClienteRepository>();

        // Services
        services.AddScoped<IClienteService, ClienteService>();

        // AutoMapper
        services.AddAutoMapper(typeof(DtoMappingProfile));

        return services;
    }
}