using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class EnderecoDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(200, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Rua { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(10, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Numero { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Cidade { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Estado { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(8, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Cep { get; set; }

    public string? Complemento { get; set; }
    public string? Referencia { get; set; }

    public ICollection<Estabelecimento>? Estabelecimentos { get; set; }
}
