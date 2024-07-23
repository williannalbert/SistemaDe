using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class ClienteContato
{
    [Key]
    public int Id { get; set; }

    public int? ClienteId { get; set; }
    public int? ContatoId { get; set; }

    [ForeignKey("ClienteId")]
    public Cliente? Cliente { get; set; }

    [ForeignKey("ContatoId")]
    public Contato? Contato { get; set; }
}
