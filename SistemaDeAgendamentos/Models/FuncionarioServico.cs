using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class FuncionarioServico
{
    [Key, Column(Order = 0)]
    public int ServicoId { get; set; }

    [Key, Column(Order = 1)]
    public int FuncionarioId { get; set; }

    [ForeignKey("ServicoId")]
    public Servico? Servico { get; set; }

    [ForeignKey("FuncionarioId")]
    public Funcionario? Funcionario { get; set; }
}
