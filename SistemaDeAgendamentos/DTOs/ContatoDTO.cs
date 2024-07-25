using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.DTOs;

public class ContatoDTO
{
    [Key]
    public int Id { get; set; }

    [MaxLength(2, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string? Ddd { get; set; }

    [MaxLength(9, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string? Telefone { get; set; }

    public string? Descricao { get; set; }

    public ICollection<ProprietarioContato>? ProprietarioContatos { get; set; }
    public ICollection<EstabelecimentoContato>? EstabelecimentoContatos { get; set; }
    public ICollection<ClienteContato>? ClienteContatos { get; set; }
}
