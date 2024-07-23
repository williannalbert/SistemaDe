using SistemaDeAgendamentos.Context;

namespace SistemaDeAgendamentos.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public AppDbContext _context;
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
