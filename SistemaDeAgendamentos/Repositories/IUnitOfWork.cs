namespace SistemaDeAgendamentos.Repositories;

public interface IUnitOfWork
{
    IAgendamentoRepository AgendamentoRepository { get; }
    IAgendaRepository AgendaRepository { get; }
    IAvaliacaoAgendamentoRepository AvaliacaoAgendamentoRepository { get; }
    IAvaliacaoEstabelecimentoRepository AvaliacaoEstabelecimentoRepository { get;}
    IAvaliacaoRepository AvaliacaoRepository { get; }
    ICargoRepository CargoRepository { get; }
    ICategoriaEstabelecimentoRepository CategoriaEstabelecimentoRepository { get; }
    IClienteContatoRepository ClienteContatoRepository { get; }
    IClienteRepository ClienteRepository { get; }  
    IContatoRepository ContatoRepository { get; }
    IEnderecoRepository EnderecoRepository { get; }
    IEstabelecimentoContatoRepository EstabelecimentoContatoRepository { get; }
    IEstabelecimentoRepository EstabelecimentoRepository { get; }
    IFuncionarioRepository FuncionarioRepository { get; }  
    IFuncionarioServicoRepository FuncionarioServicoRepository { get; } 
    IHorarioAtendimentoRepository HorarioAtendimentoRepository { get; }
    IProprietarioContatoRepository ProprietarioContatoRepository { get; }
    IServicoRepository ServicoRepository { get; }
    Task CommitAsync();
}
