using api_biblioteca_de_jogos.Entities;

namespace api_biblioteca_de_jogos.Repositories;

public interface IUsuarioRepository
{
    Usuario? GetByUsername(string username);
}
