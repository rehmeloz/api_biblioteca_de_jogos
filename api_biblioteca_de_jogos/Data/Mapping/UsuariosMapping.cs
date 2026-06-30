using api_biblioteca_de_jogos.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_biblioteca_de_jogos.Data.Mapping;

public class UsuariosMapping : IEntityTypeConfiguration<Usuarios>
{
    public void Configure(EntityTypeBuilder<Usuarios> builder)
    {
        builder.HasIndex(x => x.Username).IsUnique();
    }
}
