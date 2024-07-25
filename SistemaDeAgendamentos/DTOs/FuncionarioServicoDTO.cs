using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class FuncionarioServicoDTO
{
    [Key, Column(Order = 0)]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int ServicoId { get; set; }

    [Key, Column(Order = 1)]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int FuncionarioId { get; set; }

    [ForeignKey("ServicoId")]
    public Servico? Servico { get; set; }

    [ForeignKey("FuncionarioId")]
    public Funcionario? Funcionario { get; set; }
}
