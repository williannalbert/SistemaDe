using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class ProprietarioContatoRepository : Repository<ProprietarioContato>, IProprietarioContatoRepository
{
    public ProprietarioContatoRepository(AppDbContext context) : base(context)
    {
    }
}
