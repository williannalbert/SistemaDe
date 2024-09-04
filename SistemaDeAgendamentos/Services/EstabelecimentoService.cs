using AutoMapper;
using SistemaDeAgendamentos.DTOs;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories.Interfaces;
using SistemaDeAgendamentos.Services.Interfaces;

namespace SistemaDeAgendamentos.Services;

public class EstabelecimentoService : IEstabelecimentoService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public EstabelecimentoService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<EstabelecimentoDTO> Create(EstabelecimentoDTO estabelecimentoDTO)
    {
        var estabelecimento = _mapper.Map<Estabelecimento>(estabelecimentoDTO);
        
        var novoEstabelecimento = _unitOfWork.EstabelecimentoRepository.Create(estabelecimento);
        await _unitOfWork.CommitAsync();

        var novoEstabelecimentoDto = _mapper.Map<EstabelecimentoDTO>(novoEstabelecimento);
        return novoEstabelecimentoDto;
    }

    public async Task<EstabelecimentoDTO> Delete(int id)
    {
        var estabelecimento = await _unitOfWork.EstabelecimentoRepository.GetAsync(p => p.Id == id);
        if (estabelecimento == null)
            return null;

        var estabelecimentoDeletado = _unitOfWork.EstabelecimentoRepository.Delete(estabelecimento);
        await _unitOfWork.CommitAsync();

        var estabelecimentoDeteladoDto = _mapper.Map<EstabelecimentoDTO>(estabelecimentoDeletado);
        return estabelecimentoDeteladoDto;
    }

    public async Task<EstabelecimentoDTO> Get(int id)
    {
        var estabelecimento = await _unitOfWork.EstabelecimentoRepository.GetAsync(e => e.Id == id);
        if (estabelecimento == null)
            return null;
        var estabelecimentoDto = _mapper.Map<EstabelecimentoDTO>(estabelecimento);
        return estabelecimentoDto;
    }

    public async Task<IEnumerable<EstabelecimentoDTO>> GetAll()
    {
        var estabelecimentos = await _unitOfWork.EstabelecimentoRepository.GetAllAsync();
        if (estabelecimentos == null)
            return null;

        var estabelecimentosDto = _mapper.Map<IEnumerable<EstabelecimentoDTO>>(estabelecimentos);
        return estabelecimentosDto;
    }

    public async Task<EstabelecimentoDTO> Update(int id, EstabelecimentoDTO estabelecimentoDTO)
    {
        var estabelecimento = _mapper.Map<Estabelecimento>(estabelecimentoDTO);

        var estabelecimentoAtualizado = _unitOfWork.EstabelecimentoRepository.Update(estabelecimento);
        await _unitOfWork.CommitAsync();

        var estabelecimentoAtualizadoDto = _mapper.Map<EstabelecimentoDTO>(estabelecimentoAtualizado);
        return estabelecimentoAtualizadoDto;
    }
}
