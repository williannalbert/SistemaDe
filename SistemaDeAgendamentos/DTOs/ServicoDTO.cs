using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class ServicoDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Nome { get; set; }

    public string? Descricao { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public decimal? Preco { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? EstabelecimentoId { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento? Estabelecimento { get; set; }

    public ICollection<FuncionarioServico>? FuncionariosServicos { get; set; }
}
