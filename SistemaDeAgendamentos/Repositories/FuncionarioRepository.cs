using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
{
    public FuncionarioRepository(AppDbContext context) : base(context)
    {
    }
}
