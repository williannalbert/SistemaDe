using SistemaDeAgendamentos.DTOs.Utils;
using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
    [Maioridade]
    public DateTime? DataNascimento { get; set; }

    [Cpf(ErrorMessage = "CPF inválido")]
    [MaxLength(11, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Cpf { get; set; }
    [ExtensaoImagemValida]
    public string? ImagemPerfil { get; set; }
    [JsonIgnore]
    public ICollection<ProprietarioContato>? ProprietarioContatos { get; set; }
    [JsonIgnore]
    public ICollection<Estabelecimento>? Estabelecimentos { get; set; }
}
