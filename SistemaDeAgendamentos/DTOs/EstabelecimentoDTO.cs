using SistemaDeAgendamentos.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SistemaDeAgendamentos.DTOs;

public class EstabelecimentoDTO
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(255, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Nome { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public string? Descricao { get; set; }
    public string? Logotipo { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string? Status { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int? ProprietarioId { get; set; }
    public int? EnderecoId { get; set; }

    [ForeignKey("ProprietarioId")]
    [JsonIgnore]
    public Proprietario? Proprietario { get; set; }

    [ForeignKey("EnderecoId")]
    [JsonIgnore]
    public Endereco? Endereco { get; set; }
    [JsonIgnore]
    public ICollection<EstabelecimentoContato>? EstabelecimentoContatos { get; set; }
    [JsonIgnore]
    public ICollection<HorarioAtendimento>? HorariosAtendimento { get; set; }
    [JsonIgnore]
    public ICollection<Servico>? Servicos { get; set; }
    [JsonIgnore]
    public ICollection<Funcionario>? Funcionarios { get; set; }
    [JsonIgnore]
    public ICollection<AvaliacaoEstabelecimento>? AvaliacoesEstabelecimento { get; set; }
}
