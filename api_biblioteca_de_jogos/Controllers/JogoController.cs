using api_biblioteca_de_jogos.DTOs;
using api_biblioteca_de_jogos.Entities;
using api_biblioteca_de_jogos.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_biblioteca_de_jogos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : Controller
    {
        public readonly IJogoService _service;

        public JogoController(IJogoService service)
        {
            service = _service;
        }

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

            return Ok();
        }

        [HttpPatch("editar")]
        public async Task<IActionResult> EditarJogo(int id, JogoDTO jogoDto)
        {
            await _service.EditarJogo(id, jogoDto);

            return Ok();
        }
    }
}
