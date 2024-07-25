using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class AgendaRepository : Repository<Agenda>, IAgendaRepository
{
    public AgendaRepository(AppDbContext context) : base(context)
    {
    }
}
