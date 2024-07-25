using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class CategoriaEstabelecimentoDTO
{
    [Key]
    public int Id { get; set; }

    [MaxLength(255, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string? Nome { get; set; }
}
