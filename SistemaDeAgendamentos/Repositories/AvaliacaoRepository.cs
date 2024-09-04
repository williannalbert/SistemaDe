using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class AvaliacaoRepository : Repository<Avaliacao>, IAvaliacaoRepository
{
    public AvaliacaoRepository(AppDbContext context) : base(context)
    {
    }
}
