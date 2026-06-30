using api_biblioteca_de_jogos.Data;
using api_biblioteca_de_jogos.Entities;

namespace api_biblioteca_de_jogos.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _context;

    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public Usuario? GetByUsername(string username)
    {
        return _context.Usuarios.SingleOrDefault(u => u.Username == username);
    }
}
