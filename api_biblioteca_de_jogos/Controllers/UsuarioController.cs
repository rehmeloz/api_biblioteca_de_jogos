using api_biblioteca_de_jogos.DTOs;
using api_biblioteca_de_jogos.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_biblioteca_de_jogos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        public readonly IUsuarioService _service;
        public readonly ITokenService _tokenService;

        public UsuarioController(IUsuarioService service, ITokenService tokenService)
        {
            _service = service;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login(UsuarioDTO usuarioDto)
        {
            var user = _service.ValidateUser(usuarioDto.Username, usuarioDto.Password);

            if(user == null)
                return Unauthorized();

            var token = _tokenService.GenerateToken(user);
            return Ok(new { token });
        }

    }
}
