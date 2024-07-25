using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class HorarioAtendimentoDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? EstabelecimentoId { get; set; }

    [MaxLength(20, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string? DiaSemana { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public TimeSpan? HorarioInicio { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public TimeSpan? HorarioFim { get; set; }
    public string? Observacoes { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento? Estabelecimento { get; set; }
}
