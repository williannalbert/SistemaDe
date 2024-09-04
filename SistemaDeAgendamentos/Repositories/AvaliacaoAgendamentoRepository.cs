using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class AvaliacaoAgendamentoRepository : Repository<AvaliacaoAgendamento>, IAvaliacaoAgendamentoRepository
{
    public AvaliacaoAgendamentoRepository(AppDbContext context) : base(context)
    {
    }
}
