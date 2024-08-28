using Microsoft.EntityFrameworkCore;
using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Pagination;
using X.PagedList;

namespace SistemaDeAgendamentos.Repositories;

public class ProprietarioRepository : Repository<Proprietario>, IProprietarioRepository
{
    public ProprietarioRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<PageList<Proprietario>> GetProprietariosAsync(ProprietarioParameters proprietarioParameters)
    {
        IQueryable<Proprietario> proprietariosquery = _context.Proprietarios.AsNoTracking();

        if (!string.IsNullOrEmpty(proprietarioParameters.Nome))
            proprietariosquery = proprietariosquery.Where(p => p.Nome.ToUpper().Contains(proprietarioParameters.Nome.ToUpper()));

        if (!string.IsNullOrEmpty(proprietarioParameters.CPF))
            proprietariosquery = proprietariosquery.Where(c => c.Cpf.Equals(proprietarioParameters.CPF));

        proprietariosquery = proprietariosquery.OrderBy(p => p.Nome);

        return await PageList<Proprietario>.CreateAsync(proprietariosquery, proprietarioParameters.PageNumber, proprietarioParameters.PageSize);
            
    }
}
