using api_biblioteca_de_jogos.Data.Mapping;
using api_biblioteca_de_jogos.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_biblioteca_de_jogos.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Jogo> Jogos { get; set; }
    public DbSet<Usuarios> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new JogoMapping());
        modelBuilder.ApplyConfiguration(new UsuariosMapping());
    }
}
