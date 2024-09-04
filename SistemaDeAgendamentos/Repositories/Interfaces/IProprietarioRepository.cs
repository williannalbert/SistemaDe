using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Pagination;

namespace SistemaDeAgendamentos.Repositories.Interfaces;

public interface IProprietarioRepository : IRepository<Proprietario>
{
    Task<PageList<Proprietario>> GetProprietariosAsync(ProprietarioParameters proprietarioParameters);
}
