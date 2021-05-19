using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OpenSiconfi.Domain.Entities;

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
      optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }

    public DbSet<FonteRecursoModel> FonteRecurso { get; set; }
    public DbSet<ComplementoFonteRecurso> ComplementoFonteRecurso { get; set; }
    public DbSet<NaturezaReceita> NaturezaReceita { get; set; }
    public DbSet<InformacaoComplementar> InformacaoComplementar { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasDefaultSchema("public");
      base.OnModelCreating(modelBuilder);
    }
  }
}