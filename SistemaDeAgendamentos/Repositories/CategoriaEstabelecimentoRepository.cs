using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class CategoriaEstabelecimentoRepository : Repository<CategoriaEstabelecimento>, ICategoriaEstabelecimentoRepository
{
    public CategoriaEstabelecimentoRepository(AppDbContext context) : base(context)
    {
    }
}
