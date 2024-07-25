using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class ClienteContatoDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? ClienteId { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? ContatoId { get; set; }

    [ForeignKey("ClienteId")]
    public Cliente? Cliente { get; set; }

    [ForeignKey("ContatoId")]
    public ContatoDTO? Contato { get; set; }
}
