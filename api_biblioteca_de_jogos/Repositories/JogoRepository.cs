using api_biblioteca_de_jogos.Data;
using api_biblioteca_de_jogos.Entities;
using api_biblioteca_de_jogos.Enums;
using Microsoft.EntityFrameworkCore;

namespace api_biblioteca_de_jogos.Repositories;

public class JogoRepository : IJogoRepository
{
    public readonly AppDbContext _context;

    public JogoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task CadastrarJogo(Jogo jogo)
    {
        await _context.AddAsync(jogo);
        await _context.SaveChangesAsync();
    }

    public async Task EditarJogo(int id, Jogo jogoEditado)
    {
        var jogo = await _context.Jogos.FindAsync(id);

        if (jogo == null) return;

        jogo.Nome = jogoEditado.Nome;
        jogo.Genero = jogoEditado.Genero;
        jogo.Modo = jogoEditado.Modo;
        jogo.Categoria = jogoEditado.Categoria;
        jogo.Possui = jogoEditado.Possui;
        jogo.Nota = jogoEditado.Nota;
        jogo.Comentario = jogoEditado.Comentario;

        await _context.SaveChangesAsync();
    }

    public async Task ExcluirJogo(int id)
    {
        var jogo = await _context.Jogos.FindAsync(id);

        if (jogo == null) return;

        _context.Jogos.Remove(jogo);
        await _context.SaveChangesAsync();
    }

    public async Task<Jogo> BuscarPorId(int id)
    {
        var jogo = await _context.Jogos.FindAsync(id);

        return jogo;
    }

    public async Task<List<Jogo>> ListarJogos(int pagina, int quantidade)
    {
        return await _context.Jogos
            .Skip((pagina - 1) * quantidade)
            .Take(quantidade)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<List<Jogo>> ListarPorCategoria(ECategoria categoria, int pagina, int quantidade)
    {
        var jogosPorCategoria = await _context.Jogos.Where(c => c.Categoria == categoria)
            .Skip((pagina - 1) * quantidade)
            .Take(quantidade)
            .AsNoTracking()
            .ToListAsync();

        return jogosPorCategoria;
    }

    public async Task<List<Jogo>> ListarPorNota(int nota, int pagina, int quantidade)
    {
        var jogosPorNota = await _context.Jogos.Where(n => n.Nota == nota)
            .Skip((pagina - 1) * quantidade)
            .Take(quantidade)
            .AsNoTracking()
            .ToListAsync();

        return jogosPorNota;
    }
}
