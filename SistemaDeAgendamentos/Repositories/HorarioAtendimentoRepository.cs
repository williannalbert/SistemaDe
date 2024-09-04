using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class HorarioAtendimentoRepository : Repository<HorarioAtendimento>, IHorarioAtendimentoRepository
{
    public HorarioAtendimentoRepository(AppDbContext context) : base(context)
    {
    }
}
