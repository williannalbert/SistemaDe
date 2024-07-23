using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class AvaliacaoEstabelecimento
{
    [Key]
    public int Id { get; set; }

    public int? AvaliacaoId { get; set; }
    public int? EstabelecimentoId { get; set; }

    [ForeignKey("AvaliacaoId")]
    public Avaliacao? Avaliacao { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento? Estabelecimento { get; set; }
}
