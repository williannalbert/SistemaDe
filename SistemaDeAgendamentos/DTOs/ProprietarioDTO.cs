using SistemaDeAgendamentos.DTOs.Utils;
using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class ProprietarioDTO
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(255, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [EmailAddress(ErrorMessage = "E-mail em formato incorreto")]
    [MaxLength(255, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public DateTime? DataNascimento { get; set; }

    [Cpf(ErrorMessage = "CPF inválido")]
    [MaxLength(11, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Cpf { get; set; }

    public string? ImagemPerfil { get; set; }

    public ICollection<ProprietarioContato>? ProprietarioContatos { get; set; }
    public ICollection<Estabelecimento>? Estabelecimentos { get; set; }
}
