
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using OpenSiconfi.Infrastructure;
using Microsoft.EntityFrameworkCore;
using OpenSiconfi.Core.ServiceDiscovery;
using OpenSiconfi.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace OpenSiconfi.Core
{
  public class Startup
  {
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddServices()
              .AddRepositories()
              .AddControllers();

      services.AddDbContext<OSContext>(options =>
          options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("OpenSiconfi.Core"))
        );

      services.AddApiVersioning(config =>
      {
        config.DefaultApiVersion = new ApiVersion(1, 0);
        config.AssumeDefaultVersionWhenUnspecified = true;
        config.ReportApiVersions = true;
        config.ApiVersionReader = new HeaderApiVersionReader("x-api-version");

      });

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
          Title = "Open Siconfi",
          Version = "v1",
          Description = "Serviço destinado a disponibilização das informações abertas do SICONFI, via API Rest."
        });
      });
    }

    private static void UpdateDatabase(IApplicationBuilder app)
    {
      IServiceScope serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
      if (serviceScope != null)
      {
        OSContext context = serviceScope.ServiceProvider.GetService<OSContext>();
        if (context != null)
        {
          context.Database.Migrate();
        }
      }
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OpenSiconfi v1"));
      }

      UpdateDatabase(app);

      app.UseHttpsRedirection();
      app.UseRouting();
      app.UseAuthorization();
      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
