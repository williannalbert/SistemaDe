using SistemaDeAgendamentos.DTOs;

namespace SistemaDeAgendamentos.Services.Interfaces;

public interface IEnderecoService
{
    Task<EnderecoDTO> Get(int id);
    Task<EnderecoDTO> Create(EnderecoDTO enderecoDTO);
    Task<EnderecoDTO> Update(int id, EnderecoDTO enderecoDTO);
    Task<EnderecoDTO> Delete(int id);
}
