using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class ServicoRepository : Repository<Servico>, IServicoRepository
{
    public ServicoRepository(AppDbContext context) : base(context)
    {
    }
}
