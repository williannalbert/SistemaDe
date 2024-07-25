using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class ClienteRepository : Repository<Cliente>, IClienteRepository
{
    public ClienteRepository(AppDbContext context) : base(context)
    {
    }
}
