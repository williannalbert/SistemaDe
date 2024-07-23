using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }

    [MaxLength(255)]
    public string? Nome { get; set; }

    [EmailAddress]
    [MaxLength(255)]
    public string? Email { get; set; }

    [MaxLength(11)]
    public string? Cpf { get; set; }

    public ICollection<ClienteContato>? ClienteContatos { get; set; }
    public ICollection<Agendamento>? Agendamentos { get; set; }
}
