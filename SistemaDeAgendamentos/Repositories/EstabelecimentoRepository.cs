using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class EstabelecimentoRepository : Repository<Estabelecimento>, IEstabelecimentoRepository
{
    public EstabelecimentoRepository(AppDbContext context) : base(context)
    {
    }
}
