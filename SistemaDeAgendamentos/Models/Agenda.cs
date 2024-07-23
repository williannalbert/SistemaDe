using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class Agenda
{
    [Key]
    public int Id { get; set; }

    public DateTime? Data { get; set; }
    public TimeSpan? Horario { get; set; }
    public int? FuncionarioId { get; set; }

    [ForeignKey("FuncionarioId")]
    public Funcionario? Funcionario { get; set; }

    public ICollection<Agendamento>? Agendamentos { get; set; }
}
