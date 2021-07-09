using Microsoft.Extensions.DependencyInjection;
using OpenSiconfi.Core.Services;
using OpenSiconfi.Core.Services.Interface;
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
      services.AddScoped<IInformacaoComplementarService, InformacaoComplementarService>();
      services.AddScoped<IComplementoFonteRecursoService, ComplementoFonteRecursoService>();

      return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
      services.AddScoped<IFonteRecursoRepository, FonteRecursoRepository>();
      services.AddScoped<INaturezaReceitaRepository, NaturezaReceitaRepository>();
      services.AddScoped<IInformacaoComplementarRepository, InformacaoComplementarRepository>();
      services.AddScoped<IComplementoFonteRecursoRepository, ComplementoFonteRecursoRepository>();

      return services;
    }
  }
}