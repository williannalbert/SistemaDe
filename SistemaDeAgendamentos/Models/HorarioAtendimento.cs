using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class HorarioAtendimento
{
    [Key]
    public int Id { get; set; }

    public int? EstabelecimentoId { get; set; }

    [MaxLength(20)]
    public string? DiaSemana { get; set; }

    public TimeSpan? HorarioInicio { get; set; }
    public TimeSpan? HorarioFim { get; set; }
    public string? Observacoes { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento? Estabelecimento { get; set; }
}
