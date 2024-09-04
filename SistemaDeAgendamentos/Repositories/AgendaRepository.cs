using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class AgendaRepository : Repository<Agenda>, IAgendaRepository
{
    public AgendaRepository(AppDbContext context) : base(context)
    {
    }
}
