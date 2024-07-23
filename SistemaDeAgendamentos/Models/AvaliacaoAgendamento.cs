using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class AvaliacaoAgendamento
{
    [Key]
    public int Id { get; set; }

    public int? AvaliacaoId { get; set; }
    public int? AgendamentoId { get; set; }

    [ForeignKey("AvaliacaoId")]
    public Avaliacao? Avaliacao { get; set; }

    [ForeignKey("AgendamentoId")]
    public Agendamento? Agendamento { get; set; }
}
