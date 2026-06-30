using api_biblioteca_de_jogos.Entities;
using api_biblioteca_de_jogos.Repositories;

namespace api_biblioteca_de_jogos.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _repository;

    public UsuarioService(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public Usuario? ValidateUser(string username, string password)
    {
        var user = _repository.GetByUsername(username);

        if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            return null;

        return user;
    }
}
