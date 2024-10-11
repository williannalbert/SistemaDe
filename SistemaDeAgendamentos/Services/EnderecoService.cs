using AutoMapper;
using SistemaDeAgendamentos.DTOs;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories;
using SistemaDeAgendamentos.Repositories.Interfaces;
using SistemaDeAgendamentos.Services.Interfaces;

namespace SistemaDeAgendamentos.Services;

public class EnderecoService : IEnderecoService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public EnderecoService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<EnderecoDTO> Create(EnderecoDTO enderecoDTO)
    {
        var endereco = _mapper.Map<Endereco>(enderecoDTO);
        var novoEndereco = _unitOfWork.EnderecoRepository.Create(endereco);
        await _unitOfWork.CommitAsync();

        var novoEnderecoDto = _mapper.Map<EnderecoDTO>(novoEndereco);
        return novoEnderecoDto;
    }

    public async Task<EnderecoDTO> Delete(int id)
    {
        var endereco = await _unitOfWork.EnderecoRepository.GetAsync(p => p.Id == id);
        if (endereco == null)
            return null;

        var enderecoDeletado = _unitOfWork.EnderecoRepository.Delete(endereco);
        await _unitOfWork.CommitAsync();

        var enderecoDeletetadoDto = _mapper.Map<EnderecoDTO>(enderecoDeletado);
        return enderecoDeletetadoDto;
    }

    public async Task<EnderecoDTO> Get(int id)
    {
        var endereco = await _unitOfWork.EnderecoRepository.GetAsync(p => p.Id == id);
        if (endereco == null)
            return null;

        var enderecoDto = _mapper.Map<EnderecoDTO>(endereco);
        return enderecoDto;
    }

    public async Task<EnderecoDTO> Update(int id, EnderecoDTO enderecoDTO)
    {
        var endereco = _mapper.Map<Endereco>(enderecoDTO);

        var eenderecoAtualizado = _unitOfWork.EnderecoRepository.Update(endereco);
        await _unitOfWork.CommitAsync();

        var eenderecoAtualizadoDto = _mapper.Map<EnderecoDTO>(eenderecoAtualizado);
        return eenderecoAtualizadoDto;
    }
}
