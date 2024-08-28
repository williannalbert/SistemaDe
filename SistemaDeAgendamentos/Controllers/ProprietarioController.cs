using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SistemaDeAgendamentos.DTOs;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Pagination;
using SistemaDeAgendamentos.Repositories;



namespace SistemaDeAgendamentos.Controllers;

[Route("[controller]")]
[ApiController]
public class ProprietarioController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public ProprietarioController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProprietarioDTO>>> GetAll([FromQuery]
                                   ProprietarioParameters proprietarioParameters)
    {
        try
        {
            PageList<Proprietario> proprietarios = await _unitOfWork.ProprietarioRepository.GetProprietariosAsync(proprietarioParameters);

            return ObterProprietarios(proprietarios);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }

    private ActionResult<IEnumerable<ProprietarioDTO>> ObterProprietarios(PageList<Proprietario> proprietarios)
    {
        var metadata = new
        {
            proprietarios.CurrentPage,
            proprietarios.TotalPage,
            proprietarios.PageSize,
            proprietarios.TotalCount
        };

        Response.Headers.Append("Pagination", JsonConvert.SerializeObject(metadata));

        if (proprietarios == null)
            return NotFound("Informações não localizadas");

        var proprietariosDto = _mapper.Map<IEnumerable<ProprietarioDTO>>(proprietarios);
        return Ok(proprietariosDto);
    }

    [HttpGet("{id:int}", Name = "ObterProprietario")]
    public async Task<ActionResult<ProprietarioDTO>> Get(int id)
    {
        try
        {
            var proprietario = await _unitOfWork.ProprietarioRepository.GetAsync(e => e.Id == id);
            if (proprietario == null)
                return NotFound("Informações não localizadas");

            var proprietarioDto = _mapper.Map<ProprietarioDTO>(proprietario);
            return Ok(proprietarioDto);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }

    [HttpPost]
    public async Task<ActionResult<ProprietarioDTO>> Post(ProprietarioDTO proprietarioDTO)
    {
        try
        {
            if (proprietarioDTO == null)
                return BadRequest("Dados inválidos");

            var proprietario = _mapper.Map<Proprietario>(proprietarioDTO);

            var novoProprietario = _unitOfWork.ProprietarioRepository.Create(proprietario);
            await _unitOfWork.CommitAsync();

            var novoProprietarioDto = _mapper.Map<ProprietarioDTO>(novoProprietario);
            return new CreatedAtRouteResult("ObterProprietario", new { id = novoProprietarioDto.Id }, novoProprietarioDto);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<ProprietarioDTO>> Put(int id, ProprietarioDTO proprietarioDTO)
    {
        try
        {
            if (id != proprietarioDTO.Id)
                return BadRequest();

            var proprietario = _mapper.Map<Proprietario>(proprietarioDTO);

            var proprietarioAtualizado = _unitOfWork.ProprietarioRepository.Update(proprietario);
            await _unitOfWork.CommitAsync();

            var proprietarioAtualizadoDto = _mapper.Map<ProprietarioDTO>(proprietarioAtualizado);

            return Ok(proprietarioAtualizadoDto);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<ProprietarioDTO>> Delete(int id)
    {
        try
        {
            var proprietario = await _unitOfWork.ProprietarioRepository.GetAsync(p => p.Id == id);
            if (proprietario is null)
            {
                return NotFound("Informações não localizadas");
            }

            var proprietarioDeletado = _unitOfWork.ProprietarioRepository.Delete(proprietario);
            await _unitOfWork.CommitAsync();

            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }
}
