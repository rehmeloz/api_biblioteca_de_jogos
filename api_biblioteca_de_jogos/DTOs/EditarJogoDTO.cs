using api_biblioteca_de_jogos.Enums;

namespace api_biblioteca_de_jogos.DTOs;

public class EditarJogoDTO
{
    public string Nome { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    public EModo Modo { get; set; }
    public ECategoria Categoria { get; set; }
    public bool Possui { get; set; }
    public int Nota { get; set; }
    public string Comentario { get; set; } = string.Empty;
}
