using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class Servico
{
    [Key]
    public int Id { get; set; }

    [MaxLength(100)]
    public string? Nome { get; set; }

    public string? Descricao { get; set; }
    public decimal? Preco { get; set; }
    public int? EstabelecimentoId { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento? Estabelecimento { get; set; }

    public ICollection<FuncionarioServico>? FuncionariosServicos { get; set; }
}
