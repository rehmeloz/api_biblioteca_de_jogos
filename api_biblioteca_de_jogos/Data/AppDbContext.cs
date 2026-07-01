using api_biblioteca_de_jogos.Data.Mapping;
using api_biblioteca_de_jogos.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_biblioteca_de_jogos.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Jogo> Jogos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new JogoMapping());
        modelBuilder.ApplyConfiguration(new UsuarioMapping());

        modelBuilder.Entity<Usuario>().HasData(new Usuario
        {
            Id = 1,
            Username = "admin",
            PasswordHash = "$2a$11$T.M6IT9VsosMoQtDcGrTleUtydl8E5M.Jiyc7ZcAf4K5ahJBLJE3u",
            Role = "Admin"
        });
    }
}
