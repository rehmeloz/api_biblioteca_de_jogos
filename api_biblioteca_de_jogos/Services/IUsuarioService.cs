using api_biblioteca_de_jogos.Entities;

namespace api_biblioteca_de_jogos.Services;

public interface IUsuarioService
{
    Usuario? ValidateUser(string username, string password);
}
