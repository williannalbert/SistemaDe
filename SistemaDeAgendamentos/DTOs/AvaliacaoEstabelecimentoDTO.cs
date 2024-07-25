using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class AvaliacaoEstabelecimentoDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? AvaliacaoId { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? EstabelecimentoId { get; set; }

    [ForeignKey("AvaliacaoId")]
    public Avaliacao? Avaliacao { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento? Estabelecimento { get; set; }
}
