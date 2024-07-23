using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class Endereco
{
    [Key]
    public int Id { get; set; }

    [MaxLength(200)]
    public string? Rua { get; set; }

    [MaxLength(10)]
    public string? Numero { get; set; }

    [MaxLength(100)]
    public string? Cidade { get; set; }

    [MaxLength(100)]
    public string? Estado { get; set; }

    [MaxLength(8)]
    public string? Cep { get; set; }

    public string? Complemento { get; set; }
    public string? Referencia { get; set; }

    public ICollection<Estabelecimento>? Estabelecimentos { get; set; }
}
