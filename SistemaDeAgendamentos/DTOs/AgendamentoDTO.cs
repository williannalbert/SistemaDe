using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class AgendamentoDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int AgendaId { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int ClienteId { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public DateTime? Data { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public TimeSpan? Horario { get; set; }
    [MaxLength(20, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Status { get; set; }
    public string? Observacoes { get; set; }

    [ForeignKey("AgendaId")]
    public Agenda? Agenda { get; set; }

    [ForeignKey("ClienteId")]
    public Cliente? Cliente { get; set; }

    public ICollection<AvaliacaoAgendamento>? AvaliacoesAgendamento { get; set; }
}
