using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class AvaliacaoDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [Range(1, 5, ErrorMessage = "O campo {0} deve estar entre {1} e {2}.")]
    public int? Nota { get; set; }
    public string? Observacao { get; set; }
}
