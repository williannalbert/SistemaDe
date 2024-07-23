using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class Avaliacao
{
    [Key]
    public int Id { get; set; }

    public int? Nota { get; set; }
    public string? Observacao { get; set; }
}
