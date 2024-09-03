using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaDeAgendamentos.DTOs;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories;

namespace SistemaDeAgendamentos.Controllers;

[Route("[controller]")]
[ApiController]
public class EstabelecimentoController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public EstabelecimentoController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<EstabelecimentoDTO>>> GetAll()
    {
        try
        {
            var estabelecimentos = await _unitOfWork.EstabelecimentoRepository.GetAllAsync();
            if (estabelecimentos == null)
                return NotFound("Não há estabelecimentos cadastrados");

            var estabelecimentosDto = _mapper.Map<IEnumerable<EstabelecimentoDTO>>(estabelecimentos);
            return Ok(estabelecimentosDto);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }

    [HttpGet("{id:int}", Name = "ObterEstabelecimento")]
    public async Task<ActionResult<EstabelecimentoDTO>> Get(int id)
    {
        try
        {
            var estabelecimento = await _unitOfWork.EstabelecimentoRepository.GetAsync(e => e.Id == id);
            if(estabelecimento == null)
                return NotFound("Estabelecimento não localizado");

            var estabelecimentoDto = _mapper.Map<EstabelecimentoDTO>(estabelecimento);
            return Ok(estabelecimentoDto);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }
    [HttpPost]
    public async Task<ActionResult<EstabelecimentoDTO>> Post(EstabelecimentoDTO estabelecimentoDTO)
    {
        try
        {
            if(estabelecimentoDTO == null)
                return BadRequest("Dados inválidos");

            var proprietario = await _unitOfWork.ProprietarioRepository.GetAsync(p => p.Id == estabelecimentoDTO.ProprietarioId);
            if(proprietario is null)
                return NotFound("Proprietario não localizado");

            var estabelecimento = _mapper.Map<Estabelecimento>(estabelecimentoDTO);
            
            var novoEstabelecimento = _unitOfWork.EstabelecimentoRepository.Create(estabelecimento);
            await _unitOfWork.CommitAsync();

            var novoEstabelecimentoDto = _mapper.Map<EstabelecimentoDTO>(novoEstabelecimento);
            return new CreatedAtRouteResult("ObterEstabelecimento", new {id = novoEstabelecimentoDto.Id}, novoEstabelecimentoDto);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }
    [HttpPut("{id:int}")]
    public async Task<ActionResult<EstabelecimentoDTO>> Put(int id, EstabelecimentoDTO estabelecimentoDTO)
    {
        try
        {
            if (id != estabelecimentoDTO.Id)
                return BadRequest();

            var estabelecimento = _mapper.Map<Estabelecimento>(estabelecimentoDTO);

            var estabelecimentoAtualizado = _unitOfWork.EstabelecimentoRepository.Update(estabelecimento);
            await _unitOfWork.CommitAsync();

            var estabelecimentoAtualizadoDto = _mapper.Map<EstabelecimentoDTO>(estabelecimentoAtualizado);

            return Ok(estabelecimentoAtualizadoDto);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<EstabelecimentoDTO>> Delete(int id)
    {
        try
        {
            var estabelecimento = await _unitOfWork.EstabelecimentoRepository.GetAsync(p => p.Id == id);
            if (estabelecimento is null)
            {
                return NotFound("Informações não localizadas");
            }

            var estabelecimentoDeletado = _unitOfWork.EstabelecimentoRepository.Delete(estabelecimento);
            await _unitOfWork.CommitAsync();

            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }
}
