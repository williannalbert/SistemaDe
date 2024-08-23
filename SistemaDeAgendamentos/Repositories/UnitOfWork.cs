using SistemaDeAgendamentos.Context;

namespace SistemaDeAgendamentos.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public IAgendamentoRepository? _agendamentoRepository;

    public IAgendaRepository _agendaRepository;

    public IAvaliacaoAgendamentoRepository _avaliacaoAgendamentoRepository;

    public IAvaliacaoEstabelecimentoRepository _avaliacaoEstabelecimentoRepository;

    public IAvaliacaoRepository _avaliacaoRepository;

    public ICargoRepository _cargoRepository;

    public ICategoriaEstabelecimentoRepository _categoriaEstabelecimentoRepository;

    public IClienteContatoRepository _clienteContatoRepository;

    public IClienteRepository _clienteRepository;

    public IContatoRepository _contatoRepository;

    public IEnderecoRepository _enderecoRepository;

    public IEstabelecimentoContatoRepository _estabelecimentoContatoRepository;

    public IEstabelecimentoRepository _estabelecimentoRepository;

    public IFuncionarioRepository _funcionarioRepository;

    public IFuncionarioServicoRepository _funcionarioServicoRepository;

    public IHorarioAtendimentoRepository _horarioAtendimentoRepository;

    public IProprietarioContatoRepository _proprietarioContatoRepository;

    public IServicoRepository _servicoRepository;

    public AppDbContext _context;
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IAgendamentoRepository AgendamentoRepository
    {
        get
        {
            return _agendamentoRepository = _agendamentoRepository ?? new AgendamentoRepository(_context);
        }
    }

    public IAgendaRepository AgendaRepository
    {
        get
        {
            return _agendaRepository = _agendaRepository ?? new AgendaRepository(_context);
        }
    }

    public IAvaliacaoAgendamentoRepository AvaliacaoAgendamentoRepository
    {
        get
        {
            return _avaliacaoAgendamentoRepository = _avaliacaoAgendamentoRepository ?? new AvaliacaoAgendamentoRepository(_context);
        }
    }

    public IAvaliacaoEstabelecimentoRepository AvaliacaoEstabelecimentoRepository
    {
        get
        {
            return _avaliacaoEstabelecimentoRepository = _avaliacaoEstabelecimentoRepository ?? new AvaliacaoEstabelecimentoRepository(_context);
        }
    }

    public IAvaliacaoRepository AvaliacaoRepository
    {
        get
        {
            return _avaliacaoRepository = _avaliacaoRepository ?? new AvaliacaoRepository(_context);
        }
    }

    public ICargoRepository CargoRepository
    {
        get
        {
            return _cargoRepository = _cargoRepository ?? new CargoRepository(_context);
        }
    }

    public ICategoriaEstabelecimentoRepository CategoriaEstabelecimentoRepository
    {
        get
        {
            return _categoriaEstabelecimentoRepository = _categoriaEstabelecimentoRepository ?? new CategoriaEstabelecimentoRepository(_context);
        }
    }

    public IClienteContatoRepository ClienteContatoRepository
    {
        get
        {
            return _clienteContatoRepository = _clienteContatoRepository ?? new ClienteContatoRepository(_context);
        }
    }

    public IClienteRepository ClienteRepository
    {
        get
        {
            return _clienteRepository = _clienteRepository ?? new ClienteRepository(_context);
        }
    }

    public IContatoRepository ContatoRepository
    {
        get
        {
            return _contatoRepository = _contatoRepository ?? new ContatoRepository(_context);
        }
    }

    public IEnderecoRepository EnderecoRepository
    {
        get
        {
            return _enderecoRepository = _enderecoRepository ?? new EnderecoRepository(_context);
        }
    }

    public IEstabelecimentoContatoRepository EstabelecimentoContatoRepository
    {
        get
        {
            return _estabelecimentoContatoRepository = _estabelecimentoContatoRepository ?? new EstabelecimentoContatoRepository(_context);
        }
    }

    public IEstabelecimentoRepository EstabelecimentoRepository
    {
        get
        {
            return _estabelecimentoRepository = _estabelecimentoRepository ?? new EstabelecimentoRepository(_context);
        }
    }

    public IFuncionarioRepository FuncionarioRepository
    {
        get
        {
            return _funcionarioRepository = _funcionarioRepository ?? new FuncionarioRepository(_context);
        }
    }

    public IFuncionarioServicoRepository FuncionarioServicoRepository
    {
        get
        {
            return _funcionarioServicoRepository = _funcionarioServicoRepository ?? new FuncionarioServicoRepository(_context);
        }
    }

    public IHorarioAtendimentoRepository HorarioAtendimentoRepository
    {
        get
        {
            return _horarioAtendimentoRepository = _horarioAtendimentoRepository ?? new HorarioAtendimentoRepository(_context);
        }
    }

    public IProprietarioContatoRepository ProprietarioContatoRepository
    {
        get
        {
            return _proprietarioContatoRepository = _proprietarioContatoRepository ?? new ProprietarioContatoRepository(_context);
        }
    }

    public IServicoRepository ServicoRepository
    {
        get
        {
            return _servicoRepository = _servicoRepository ?? new ServicoRepository(_context);
        }
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
