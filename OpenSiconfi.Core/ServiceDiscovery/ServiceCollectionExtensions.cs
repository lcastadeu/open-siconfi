using Microsoft.Extensions.DependencyInjection;
using OpenSiconfi.Application.Services;
using OpenSiconfi.Application.Services.Interface;
using OpenSiconfi.Domain.Repositories;
using OpenSiconfi.Domain.Repositories.Interface;

namespace OpenSiconfi.Core.ServiceDiscovery
{
  public static class ServiceCollectionExtensions
  {
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
      services.AddScoped<IAbstractService, AbstractService>();
      services.AddScoped<IFonteRecursoService, FonteRecursoService>();
      services.AddScoped<INaturezaReceitaService, NaturezaReceitaService>();

      return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
      services.AddScoped<IFonteRecursoRepository, FonteRecursoRepository>();
      services.AddScoped<INaturezaReceitaRepository, NaturezaReceitaRepository>();
      return services;
    }
  }
}