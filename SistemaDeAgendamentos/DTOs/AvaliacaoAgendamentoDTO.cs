using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class AvaliacaoAgendamentoDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? AvaliacaoId { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? AgendamentoId { get; set; }

    [ForeignKey("AvaliacaoId")]
    public Avaliacao? Avaliacao { get; set; }

    [ForeignKey("AgendamentoId")]
    public Agendamento? Agendamento { get; set; }
}
