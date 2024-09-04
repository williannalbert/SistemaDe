using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class ContatoRepository : Repository<Contato>, IContatoRepository
{
    public ContatoRepository(AppDbContext context) : base(context)
    {
    }
}
