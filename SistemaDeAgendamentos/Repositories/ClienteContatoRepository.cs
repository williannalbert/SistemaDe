using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class ClienteContatoRepository : Repository<ClienteContato>, IClienteContatoRepository
{
    public ClienteContatoRepository(AppDbContext context) : base(context)
    {
    }
}
