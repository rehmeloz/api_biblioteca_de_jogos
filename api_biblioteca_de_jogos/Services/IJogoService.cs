using api_biblioteca_de_jogos.DTOs;
using api_biblioteca_de_jogos.Entities;
using api_biblioteca_de_jogos.Enums;

namespace api_biblioteca_de_jogos.Services;

public interface IJogoService
{
    public Task CadastrarJogo(Jogo jogo);
    public Task EditarJogo(int id, JogoDTO jogoDto);
    public Task ExcluirJogo(int id);
    public Task BuscarPorId(int id);
    public Task<List<Jogo>> ListarJogos(int pagina, int quantidade);
    public Task<List<Jogo>> ListarPorCategoria(ECategoria categoria, int pagina, int quantidade);
    public Task<List<Jogo>> ListaPorNota(int nota, int pagina, int quantidade);
}
