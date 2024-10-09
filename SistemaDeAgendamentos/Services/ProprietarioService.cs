using AutoMapper;
using SistemaDeAgendamentos.DTOs;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Pagination;
using SistemaDeAgendamentos.Repositories.Interfaces;
using SistemaDeAgendamentos.Services.Interfaces;

namespace SistemaDeAgendamentos.Services;

public class ProprietarioService : IProprietarioService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public ProprietarioService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<ProprietarioDTO> Create(ProprietarioDTO proprietarioDTO)
    {
        var proprietario = _mapper.Map<Proprietario>(proprietarioDTO);

        var novoProprietario = _unitOfWork.ProprietarioRepository.Create(proprietario);
        await _unitOfWork.CommitAsync();

        var novoProprietarioDto = _mapper.Map<ProprietarioDTO>(novoProprietario);
        return novoProprietarioDto;
    }

    public async Task<ProprietarioDTO> Delete(int id)
    {
        var proprietario = await _unitOfWork.ProprietarioRepository.GetAsync(p => p.Id == id);
        if (proprietario is null)
            return null;

        var proprietarioDeletado = _unitOfWork.ProprietarioRepository.Delete(proprietario);
        await _unitOfWork.CommitAsync();

        var proprietarioDeletadoDto = _mapper.Map<ProprietarioDTO>(proprietarioDeletado);
        return proprietarioDeletadoDto;
    }

    public async Task<ProprietarioDTO> Get(int id)
    {
        var proprietario = await _unitOfWork.ProprietarioRepository.GetAsync(e => e.Id == id);
        if (proprietario == null)
            return null;

        var proprietarioDto = _mapper.Map<ProprietarioDTO>(proprietario);
        return proprietarioDto;
    }

    public async Task<IEnumerable<ProprietarioDTO>> GetAll()
    {
        IEnumerable<Proprietario> proprietarios = await _unitOfWork.ProprietarioRepository.GetAllAsync();
        if (proprietarios == null)
            return null;

        return _mapper.Map<IEnumerable<ProprietarioDTO>>(proprietarios);
    }

    public async Task<PageList<ProprietarioDTO>> GetAllPaged(ProprietarioParameters proprietarioParameters)
    {
        PageList<Proprietario> proprietarios = await _unitOfWork.ProprietarioRepository.GetProprietariosAsync(proprietarioParameters);
        if (proprietarios == null)
            return null;

        var proprietariosDto = _mapper.Map<IEnumerable<ProprietarioDTO>>(proprietarios);

        return new PageList<ProprietarioDTO>(proprietariosDto.ToList(), proprietarios.TotalCount, proprietarios.CurrentPage, proprietarios.PageSize);
    }

    public async Task<ProprietarioDTO> Update(int id, ProprietarioDTO proprietarioDTO)
    {
        var proprietario = _mapper.Map<Proprietario>(proprietarioDTO);

        var proprietarioAtualizado = _unitOfWork.ProprietarioRepository.Update(proprietario);
        await _unitOfWork.CommitAsync();

        var proprietarioAtualizadoDto = _mapper.Map<ProprietarioDTO>(proprietarioAtualizado);
        return proprietarioAtualizadoDto;
    }

}
