using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
{
    public EnderecoRepository(AppDbContext context) : base(context)
    {
    }
}
