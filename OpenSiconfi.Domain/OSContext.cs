using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OpenSiconfi.Domain.Entities;
using OpenSiconfi.Domain.Seed;

namespace OpenSiconfi.Domain
{
  public class OSContext : DbContext
  {
    public IConfiguration Configuration { get; set; }

    public OSContext(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("OpenSiconfi.Core"));
    }

    public virtual DbSet<FonteRecurso> FonteRecurso { get; set; }
    public virtual DbSet<ComplementoFonteRecurso> ComplementoFonteRecurso { get; set; }
    public virtual DbSet<NaturezaReceita> NaturezaReceita { get; set; }
    public virtual DbSet<InformacaoComplementar> InformacaoComplementar { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasDefaultSchema("public");
      base.OnModelCreating(modelBuilder);

      SeedFonteRecurso.Data(modelBuilder);
      SeedNaturezaReceita.Data(modelBuilder);
    }
  }
}