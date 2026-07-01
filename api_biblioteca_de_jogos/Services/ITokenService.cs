using api_biblioteca_de_jogos.Entities;

namespace api_biblioteca_de_jogos.Services;

public interface ITokenService
{
   string GenerateToken(Usuario usuario);
}