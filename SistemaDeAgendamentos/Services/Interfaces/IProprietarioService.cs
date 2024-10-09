using SistemaDeAgendamentos.DTOs;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Pagination;

namespace SistemaDeAgendamentos.Services.Interfaces;

public interface IProprietarioService
{
    Task<IEnumerable<ProprietarioDTO>> GetAll();
    Task<PageList<ProprietarioDTO>> GetAllPaged(ProprietarioParameters proprietarioParameters);
    Task<ProprietarioDTO> Get(int id);
    Task<ProprietarioDTO> Create(ProprietarioDTO proprietarioDTO);
    Task<ProprietarioDTO> Update(int id, ProprietarioDTO proprietarioDTO);
    Task<ProprietarioDTO> Delete(int id);
}
