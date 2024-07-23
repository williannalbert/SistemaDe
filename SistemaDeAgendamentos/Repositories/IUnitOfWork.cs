namespace SistemaDeAgendamentos.Repositories;

public interface IUnitOfWork
{
    Task CommitAsync();
}
