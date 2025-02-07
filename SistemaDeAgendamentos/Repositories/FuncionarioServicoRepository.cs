﻿using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;

namespace SistemaDeAgendamentos.Repositories;

public class FuncionarioServicoRepository : Repository<FuncionarioServico>, IFuncionarioServicoRepository
{
    public FuncionarioServicoRepository(AppDbContext context) : base(context)
    {
    }
}
