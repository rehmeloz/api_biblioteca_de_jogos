using api_biblioteca_de_jogos.Entities;
using api_biblioteca_de_jogos.Enums;
using api_biblioteca_de_jogos.Repositories;

namespace api_biblioteca_de_jogos.Services;

public class JogoService : IJogoService
{
    private readonly IJogoRepository _repository;

    public JogoService(IJogoRepository repository)
    {
        _repository = repository;
    }

    public async Task<Jogo> CadastrarJogo(Jogo jogo)
    {
        if (jogo.Nota > 5)
            throw new Exception("A nota não pode ser maior que 5!");

        await _repository.CadastrarJogo(jogo);

        return jogo;
    }

    public async Task EditarJogo(int id, Jogo jogoEditado)
    {
        var jogo = _repository.BuscarPorId(id);

        if (jogo == null)
            throw new Exception("O jogo não foi encontrado!");

        await _repository.EditarJogo(id, jogoEditado);
    }

    public async Task ExcluirJogo(int id)
    {
        var jogo = await _repository.BuscarPorId(id);

        if (jogo == null)
            throw new Exception($"O jogo de id {id} não foi encontrado!");

        await _repository.ExcluirJogo(id);
    }

    public async Task<Jogo> BuscarPorId(int id)
    {
        var jogo = await _repository.BuscarPorId(id);

        if (jogo == null)
            throw new Exception($"O jogo de id {id} não foi encontrado!");

        return jogo;
    }

    public async Task<List<Jogo>> ListarJogos(int pagina, int quantidade)
    {
       var jogos = await _repository.ListarJogos(pagina, quantidade);

        if (jogos.Count == 0)
            throw new Exception("A lista de jogos está vazia.");

        return jogos;     
    }

    public async Task<List<Jogo>> ListarPorCategoria(ECategoria categoria, int pagina, int quantidade)
    {
        return await _repository.ListarPorCategoria(categoria, pagina, quantidade);
    }

    public async Task<List<Jogo>> ListaPorNota(int nota, int pagina, int quantidade)
    {
        if (nota > 5)
            throw new Exception("A nota não pode ser maior que 5!");

        return await _repository.ListaPorNota(nota, pagina, quantidade);
    }
}
