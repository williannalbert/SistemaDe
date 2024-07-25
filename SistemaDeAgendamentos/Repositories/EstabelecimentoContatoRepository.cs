using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class EstabelecimentoContatoRepository : Repository<EstabelecimentoContato>, IEstabelecimentoContatoRepository
{
    public EstabelecimentoContatoRepository(AppDbContext context) : base(context)
    {
    }
}
