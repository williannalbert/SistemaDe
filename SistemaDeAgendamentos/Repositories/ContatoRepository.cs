using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class ContatoRepository : Repository<Contato>, IContatoRepository
{
    public ContatoRepository(AppDbContext context) : base(context)
    {
    }
}
