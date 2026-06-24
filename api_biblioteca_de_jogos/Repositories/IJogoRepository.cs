using api_biblioteca_de_jogos.DTOs;
using api_biblioteca_de_jogos.Entities;
using api_biblioteca_de_jogos.Enums;

namespace api_biblioteca_de_jogos.Repositories;

public interface IJogoRepository
{
    public Task CadastrarJogo(Jogo jogo);
    public Task EditarJogo(int id, Jogo jogo);
    public Task ExcluirJogo(int id);
    public Task<Jogo> BuscarPorId(int id);
    public Task<List<Jogo>> ListarJogos(int pagina, int quantidade);
    public Task<List<Jogo>> ListarPorCategoria(ECategoria categoria, int pagina, int quantidade);
    public Task<List<Jogo>> ListaPorNota(int nota, int pagina, int quantidade);
}
