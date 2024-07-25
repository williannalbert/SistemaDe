using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Repositories;

public class CargoRepository : Repository<Cargo>, ICargoRepository
{
    public CargoRepository(AppDbContext context) : base(context)
    {
    }
}
