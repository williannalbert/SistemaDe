using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class EstabelecimentoContato
{
    [Key]
    public int Id { get; set; }

    public int? EstabelecimentoId { get; set; }
    public int? ContatoId { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento? Estabelecimento { get; set; }

    [ForeignKey("ContatoId")]
    public Contato? Contato { get; set; }
}
