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

    [HttpGet("{id:int}")]
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

            var estabelecimento = _mapper.Map<Estabelecimento>(estabelecimentoDTO);
            
            var novoEstabelecimento = _unitOfWork.EstabelecimentoRepository.Create(estabelecimento);
            await _unitOfWork.CommitAsync();

            var novoEstabelecimentoDto = _mapper.Map<EstabelecimentoDTO>(novoEstabelecimento);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }
}
