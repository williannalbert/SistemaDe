using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Pagination;

namespace SistemaDeAgendamentos.Repositories;

public interface IProprietarioRepository : IRepository<Proprietario>
{
    Task<PageList<Proprietario>> GetProprietariosAsync(ProprietarioParameters proprietarioParameters);
}
