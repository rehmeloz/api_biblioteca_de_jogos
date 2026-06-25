using api_biblioteca_de_jogos.Enums;
using System.Text.Json.Serialization;

namespace api_biblioteca_de_jogos.Entities;

public class Jogo
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    //[JsonConverter(typeof(JsonStringEnumConverter))]
    public EModo Modo { get; set; }
    //[JsonConverter(typeof(JsonStringEnumConverter))]
    public ECategoria Categoria { get; set; }
    public bool Possui { get; set; }
    public int Nota { get; set; }
    public string Comentario { get; set; } = string.Empty;
}
