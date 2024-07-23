using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAgendamentos.Models;

public class Estabelecimento
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(255)]
    public string? Nome { get; set; }

    public string? Descricao { get; set; }
    public string? Logotipo { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Status { get; set; }

    public int? ProprietarioId { get; set; }
    public int? EnderecoId { get; set; }

    [ForeignKey("ProprietarioId")]
    public Proprietario? Proprietario { get; set; }

    [ForeignKey("EnderecoId")]
    public Endereco? Endereco { get; set; }

    public ICollection<EstabelecimentoContato>? EstabelecimentoContatos { get; set; }
    public ICollection<HorarioAtendimento>? HorariosAtendimento { get; set; }
    public ICollection<Servico>? Servicos { get; set; }
    public ICollection<Funcionario>? Funcionarios { get; set; }
    public ICollection<AvaliacaoEstabelecimento>? AvaliacoesEstabelecimento { get; set; }
}
