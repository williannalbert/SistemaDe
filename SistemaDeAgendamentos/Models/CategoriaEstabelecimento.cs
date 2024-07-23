using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class CategoriaEstabelecimento
{
    [Key]
    public int Id { get; set; }

    [MaxLength(255)]
    public string? Nome { get; set; }
}
