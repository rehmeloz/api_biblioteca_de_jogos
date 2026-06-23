using api_biblioteca_de_jogos.DTOs;
using api_biblioteca_de_jogos.Entities;
using api_biblioteca_de_jogos.Enums;
using api_biblioteca_de_jogos.Repositories;
using SQLitePCL;

namespace api_biblioteca_de_jogos.Services;

public class JogoService : IJogoService
{
    public readonly IJogoRepository _repository;

    public JogoService(IJogoRepository repository)
    {
        repository = _repository;
    }

    public async Task CadastrarJogo(Jogo jogo)
    {
        await _repository.CadastrarJogo(jogo);
    }

    public async Task EditarJogo(int id, EditarJogoDTO jogoEditado)
    {
        var jogo = _repository.BuscarPorId(id);

        if (jogo == null)
            throw new Exception("O jogo não foi encontrado!");

        await _repository.EditarJogo(id, jogoEditado);
    }

    public async Task ExcluirJogo(int id)
    {
        var jogo = _repository.BuscarPorId(id);

        if (jogo == null)
            throw new Exception("O jogo não foi encontrado!");

        await _repository.ExcluirJogo(id);
    }

    public async Task BuscarPorId(int id)
    {
        var jogo = _repository.BuscarPorId(id);

        if (jogo == null)
            throw new Exception($"O jogo de id {id} não foi encontrado!");

        await _repository.BuscarPorId(id);
    }

    public async Task<List<Jogo>> ListarJogos(int pagina, int quantidade)
    {
       return await _repository.ListarJogos(pagina, quantidade);
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
