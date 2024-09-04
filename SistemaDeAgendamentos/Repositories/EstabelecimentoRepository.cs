using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class EstabelecimentoRepository : Repository<Estabelecimento>, IEstabelecimentoRepository
{
    public EstabelecimentoRepository(AppDbContext context) : base(context)
    {
    }
}
