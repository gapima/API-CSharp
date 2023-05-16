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
        services.AddScoped<IContatoClienteRepository, ContatoClienteRepository>();
        services.AddScoped<IContatoIndicadorRepository, ContatoIndicadorRepository>();
        services.AddScoped<ICredoresRepository, CredoresRepository>();
        services.AddScoped<IDocumentoRepository, DocumentoRepository>();
        services.AddScoped<IGrupoRepository, GrupoRespository>();
        services.AddScoped<IIndicadorRepository, IndicadorRepository>();
        services.AddScoped<IProcessoRepository, ProcessoRepository>();
        services.AddScoped<IRendaClienteRepository, RendaClienteRepository>();
        services.AddScoped<ITipoDocumentoRepository, TipoDocumentoRepository>();
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();

        // Services
        services.AddScoped<IClienteService, ClienteService>();
        services.AddScoped<IContatoClienteService, ContatoClienteService>();
        services.AddScoped<IContatoIndicadorService, ContatoIndicadorService>();
        services.AddScoped<ICredoresService, CredoresService>();
        services.AddScoped<IDocumentoService, DocumentoService>();
        services.AddScoped<IGrupoService, GrupoService>();
        services.AddScoped<IIndicadorService, IndicadorService>();
        services.AddScoped<IProcessoService, ProcessoService>();
        services.AddScoped<IRendaClienteService, RendaClienteService>();
        services.AddScoped<ISituacaoCreditoService, SituacaoCreditoService>();
        services.AddScoped<ITipoDocumentoService, TipoDocumentoService>();
        services.AddScoped<IUsuarioService, UsuarioService>();

        // AutoMapper
        services.AddAutoMapper(typeof(DtoMappingProfile));

        return services;
    }
}