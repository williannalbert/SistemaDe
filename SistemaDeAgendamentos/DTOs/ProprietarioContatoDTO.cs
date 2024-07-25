using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class ProprietarioContatoDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? ProprietarioId { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? ContatoId { get; set; }

    [ForeignKey("ProprietarioId")]
    public Proprietario? Proprietario { get; set; }

    [ForeignKey("ContatoId")]
    public Contato? Contato { get; set; }
}
