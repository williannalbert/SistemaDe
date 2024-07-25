using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class FuncionarioDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(255, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Nome { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? EstabelecimentoId { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? CargoId { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento? Estabelecimento { get; set; }

    [ForeignKey("CargoId")]
    public Cargo? Cargo { get; set; }

    public ICollection<FuncionarioServico>? FuncionariosServicos { get; set; }
    public ICollection<Agenda>? Agendas { get; set; }
}
