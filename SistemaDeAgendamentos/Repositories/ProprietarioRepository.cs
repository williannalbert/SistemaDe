using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class ProprietarioRepository : Repository<Proprietario>, IProprietarioRepository
{
    public ProprietarioRepository(AppDbContext context) : base(context)
    {
    }
}
