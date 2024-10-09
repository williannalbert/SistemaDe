using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SistemaDeAgendamentos.DTOs;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Pagination;
using SistemaDeAgendamentos.Repositories.Interfaces;
using SistemaDeAgendamentos.Services.Interfaces;



namespace SistemaDeAgendamentos.Controllers;

[Route("[controller]")]
[ApiController]
public class ProprietarioController : Controller
{
    private readonly IProprietarioService _proprietarioService;
    public ProprietarioController(IProprietarioService proprietarioService)
    {
        _proprietarioService = proprietarioService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProprietarioDTO>>> GetAll([FromQuery]
                                   ProprietarioParameters proprietarioParameters)
    {
        try
        {
            var proprietariosDto = await _proprietarioService.GetAllPaged(proprietarioParameters);

            if(proprietariosDto is null)
                return NotFound("Informações não localizadas");

            var metadata = new
            {
                proprietariosDto.CurrentPage,
                proprietariosDto.TotalPage,
                proprietariosDto.PageSize,
                proprietariosDto.TotalCount
            };

            Response.Headers.Append("Pagination", JsonConvert.SerializeObject(metadata));

            return Ok(proprietariosDto);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }


    [HttpGet("{id:int}", Name = "ObterProprietario")]
    public async Task<ActionResult<ProprietarioDTO>> Get(int id)
    {
        try
        {
            var proprietarioDto = await _proprietarioService.Get(id);
            if (proprietarioDto == null)
                return NotFound("Proprietario não localizado");

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

            var novoProprietarioDto = await _proprietarioService.Create(proprietarioDTO);
            
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

            var proprietarioAtualizadoDto = await _proprietarioService.Update(id, proprietarioDTO);

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
            var proprietario = await _proprietarioService.Delete(id);
            if(proprietario is null)
                return NotFound("Informações não localizadas");

            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }
}
