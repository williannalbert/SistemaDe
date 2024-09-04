using SistemaDeAgendamentos.DTOs;

namespace SistemaDeAgendamentos.Services.Interfaces;

public interface IEstabelecimentoService
{
    Task<IEnumerable<EstabelecimentoDTO>> GetAll();
    Task<EstabelecimentoDTO> Get(int id);
    Task<EstabelecimentoDTO> Create(EstabelecimentoDTO estabelecimentoDTO);
    Task<EstabelecimentoDTO> Update(int id, EstabelecimentoDTO estabelecimentoDTO);
    Task<EstabelecimentoDTO> Delete(int id);
}
