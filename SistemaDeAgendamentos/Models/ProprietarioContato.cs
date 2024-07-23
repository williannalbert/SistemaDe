using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class ProprietarioContato
{
    [Key]
    public int Id { get; set; }

    public int? ProprietarioId { get; set; }
    public int? ContatoId { get; set; }

    [ForeignKey("ProprietarioId")]
    public Proprietario? Proprietario { get; set; }

    [ForeignKey("ContatoId")]
    public Contato? Contato { get; set; }
}
