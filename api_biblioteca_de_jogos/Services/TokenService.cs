using api_biblioteca_de_jogos.Entities;

namespace api_biblioteca_de_jogos.Services;

public class TokenService : ITokenService
{
    private readonly IConfiguration _config;

    public TokenService(IConfiguration config)
    {
        _config = config;
    }

    public string GenerateToken(Usuario usuario)
    {
        return "";
    }
}
