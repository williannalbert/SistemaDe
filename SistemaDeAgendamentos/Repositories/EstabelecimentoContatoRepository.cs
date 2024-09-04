using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class EstabelecimentoContatoRepository : Repository<EstabelecimentoContato>, IEstabelecimentoContatoRepository
{
    public EstabelecimentoContatoRepository(AppDbContext context) : base(context)
    {
    }
}
