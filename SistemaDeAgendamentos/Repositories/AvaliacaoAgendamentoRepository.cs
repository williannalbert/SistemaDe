using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class AvaliacaoAgendamentoRepository : Repository<AvaliacaoAgendamento>, IAvaliacaoAgendamentoRepository
{
    public AvaliacaoAgendamentoRepository(AppDbContext context) : base(context)
    {
    }
}
