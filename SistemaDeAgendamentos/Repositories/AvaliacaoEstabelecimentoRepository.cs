using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class AvaliacaoEstabelecimentoRepository : Repository<AvaliacaoEstabelecimento>, IAvaliacaoEstabelecimentoRepository
{
    public AvaliacaoEstabelecimentoRepository(AppDbContext context) : base(context)
    {
    }
}
