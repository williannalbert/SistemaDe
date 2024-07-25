using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class ClienteContatoRepository : Repository<ClienteContato>, IClienteContatoRepository
{
    public ClienteContatoRepository(AppDbContext context) : base(context)
    {
    }
}
