using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class AgendaDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public DateTime? Data { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public TimeSpan? Horario { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? FuncionarioId { get; set; }

    [ForeignKey("FuncionarioId")]
    public Funcionario? Funcionario { get; set; }

    public ICollection<Agendamento>? Agendamentos { get; set; }
}
