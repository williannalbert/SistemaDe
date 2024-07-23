using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class Agendamento
{
    [Key]
    public int Id { get; set; }

    public int AgendaId { get; set; }
    public int ClienteId { get; set; }

    public DateTime? Data { get; set; }
    public TimeSpan? Horario { get; set; }

    [MaxLength(20)]
    public string? Status { get; set; }

    public string? Observacoes { get; set; }

    [ForeignKey("AgendaId")]
    public Agenda? Agenda { get; set; }

    [ForeignKey("ClienteId")]
    public Cliente? Cliente { get; set; }

    public ICollection<AvaliacaoAgendamento>? AvaliacoesAgendamento { get; set; }
}
