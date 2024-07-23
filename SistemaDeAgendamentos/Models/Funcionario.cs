using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class Funcionario
{
    [Key]
    public int Id { get; set; }

    [MaxLength(255)]
    public string? Nome { get; set; }

    public int? EstabelecimentoId { get; set; }
    public int? CargoId { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento? Estabelecimento { get; set; }

    [ForeignKey("CargoId")]
    public Cargo? Cargo { get; set; }

    public ICollection<FuncionarioServico>? FuncionariosServicos { get; set; }
    public ICollection<Agenda>? Agendas { get; set; }
}
