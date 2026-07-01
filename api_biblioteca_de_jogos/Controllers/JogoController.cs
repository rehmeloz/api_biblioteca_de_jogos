using api_biblioteca_de_jogos.DTOs;
using api_biblioteca_de_jogos.Entities;
using api_biblioteca_de_jogos.Enums;
using api_biblioteca_de_jogos.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_biblioteca_de_jogos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : Controller
    {
        private readonly IJogoService _service;

        public JogoController(IJogoService service)
        {
            _service = service;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastrarJogo(JogoDTO jogoDto)
        {
            var jogo = new Jogo
            {
                Nome = jogoDto.Nome,
                Genero = jogoDto.Genero,
                Modo = jogoDto.Modo,
                Categoria = jogoDto.Categoria,
                Possui = jogoDto.Possui,
                Nota = jogoDto.Nota,
                Comentario = jogoDto.Comentario
            };

            await _service.CadastrarJogo(jogo);

            return Ok(jogo);
        }

        [Authorize(Roles = "Admin")]
        [HttpPatch("editar")]
        public async Task<IActionResult> EditarJogo(int id, JogoDTO jogoDto)
        {
            var jogo = new Jogo
            {
                Nome = jogoDto.Nome,
                Genero = jogoDto.Genero,
                Modo = jogoDto.Modo,
                Categoria = jogoDto.Categoria,
                Possui = jogoDto.Possui,
                Nota = jogoDto.Nota,
                Comentario = jogoDto.Comentario
            };

            await _service.EditarJogo(id, jogo);

            return Ok(jogo);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("excluir")]
        public async Task<IActionResult> ExcluirJogo(int id)
        {
            try
            {
                await _service.ExcluirJogo(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("id")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            var jogo = await _service.BuscarPorId(id);

            return Ok(jogo);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarJogos( int pagina = 1, int quantidade = 5)
        {
            var jogos = await _service.ListarJogos(pagina, quantidade);

            return Ok(jogos);
        }

        [HttpGet("listar/categoria")]
        public async Task<IActionResult> ListarPorCategoria(ECategoria categoria, int pagina = 1, int quantidade = 5)
        {
            var jogos = await _service.ListarPorCategoria(categoria, pagina, quantidade);

            return Ok(jogos);
        }

        [HttpGet("listar/nota")]
        public async Task<IActionResult> ListarPorNota(int nota, int pagina = 1, int quantidade = 5)
        {
            var jogos = await _service.ListarPorNota(nota, pagina, quantidade);

            return Ok(jogos);
        }
    }
}
