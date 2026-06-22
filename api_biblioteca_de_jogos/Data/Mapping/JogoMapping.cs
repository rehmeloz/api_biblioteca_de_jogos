using api_biblioteca_de_jogos.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_biblioteca_de_jogos.Data.Mapping;

public class JogoMapping : IEntityTypeConfiguration<Jogo>
{
    public void Configure(EntityTypeBuilder<Jogo> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(n => n.Nome).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        builder.Property(g => g.Genero).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        builder.Property(m => m.Modo).IsRequired();
        builder.Property(c => c.Categoria).IsRequired();
        builder.Property(n => n.Nome).HasMaxLength(1);
        builder.Property(c => c.Comentario).HasMaxLength(150);
    }
}
