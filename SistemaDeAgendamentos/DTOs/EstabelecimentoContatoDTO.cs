using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class EstabelecimentoContatoDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? EstabelecimentoId { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? ContatoId { get; set; }

    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento? Estabelecimento { get; set; }

    [ForeignKey("ContatoId")]
    public Contato? Contato { get; set; }
}
