using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class AgendamentoRepository : Repository<Agendamento>, IAgendamentoRepository
{
    public AgendamentoRepository(AppDbContext context) : base(context)
    {
        
    }
}
