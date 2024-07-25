using SistemaDeAgendamentos.DTOs.Utils;
using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class ClienteDTO
{
    [Key]
    public int Id { get; set; }

    [MaxLength(255, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string? Nome { get; set; }

    [EmailAddress(ErrorMessage = "E-mail em formato incorreto")]
    [MaxLength(255, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Email { get; set; }

    [MaxLength(11, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    [Cpf(ErrorMessage = "CPF inválido")]
    public string? Cpf { get; set; }

    public ICollection<ClienteContato>? ClienteContatos { get; set; }
    public ICollection<Agendamento>? Agendamentos { get; set; }
}
