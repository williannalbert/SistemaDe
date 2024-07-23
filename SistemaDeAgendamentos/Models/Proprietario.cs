using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class Proprietario
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(255)]
    public string? Nome { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(255)]
    public string? Email { get; set; }

    public DateTime? DataNascimento { get; set; }

    [Required]
    [MaxLength(11)]
    public string? Cpf { get; set; }

    public string? ImagemPerfil { get; set; }

    public ICollection<ProprietarioContato>? ProprietarioContatos { get; set; }
    public ICollection<Estabelecimento>? Estabelecimentos { get; set; }
}
