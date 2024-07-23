using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class Contato
{
    [Key]
    public int Id { get; set; }

    [MaxLength(2)]
    public string? Ddd { get; set; }

    [MaxLength(9)]
    public string? Telefone { get; set; }

    public string? Descricao { get; set; }

    public ICollection<ProprietarioContato>? ProprietarioContatos { get; set; }
    public ICollection<EstabelecimentoContato>? EstabelecimentoContatos { get; set; }
    public ICollection<ClienteContato>? ClienteContatos { get; set; }
}
