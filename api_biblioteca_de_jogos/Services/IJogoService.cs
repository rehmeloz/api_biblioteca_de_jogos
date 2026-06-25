using api_biblioteca_de_jogos.Entities;
using api_biblioteca_de_jogos.Enums;

namespace api_biblioteca_de_jogos.Services;

public interface IJogoService
{
    public Task<Jogo> CadastrarJogo(Jogo jogo);
    public Task EditarJogo(int id, Jogo jogo);
    public Task ExcluirJogo(int id);
    public Task<Jogo> BuscarPorId(int id);
    public Task<List<Jogo>> ListarJogos(int pagina, int quantidade);
    public Task<List<Jogo>> ListarPorCategoria(ECategoria categoria, int pagina, int quantidade);
    public Task<List<Jogo>> ListarPorNota(int nota, int pagina, int quantidade);
}
