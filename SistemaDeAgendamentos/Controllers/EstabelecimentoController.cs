using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaDeAgendamentos.DTOs;
using SistemaDeAgendamentos.Models;
using SistemaDeAgendamentos.Repositories;
using SistemaDeAgendamentos.Services.Interfaces;

namespace SistemaDeAgendamentos.Controllers;

[Route("[controller]")]
[ApiController]
public class EstabelecimentoController : Controller
{
    private readonly IEstabelecimentoService _estabelecimentoService;
    public EstabelecimentoController(IEstabelecimentoService estabelecimentoService)
    {
        _estabelecimentoService = estabelecimentoService;   
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<EstabelecimentoDTO>>> GetAll()
    {
        try
        {
            var estabelecimentos = await _estabelecimentoService.GetAll();
            if (estabelecimentos == null)
                return NotFound("Não há estabelecimentos cadastrados");

            
            return Ok(estabelecimentos);
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
            var estabelecimentoDTO = await _estabelecimentoService.Get(id);
            if(estabelecimentoDTO == null)
                return NotFound("Estabelecimento não localizado");

            
            return Ok(estabelecimentoDTO);
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

            var novoEstabelecimentoDto = await _estabelecimentoService.Create(estabelecimentoDTO);
            
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

            var estabelecimentoAtualizadoDto = await _estabelecimentoService.Update(id, estabelecimentoDTO);
            return Ok(estabelecimentoAtualizadoDto);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        try
        {
            var estabelecimento = await _estabelecimentoService.Delete(id);
            if (estabelecimento is null)
            {
                return NotFound("Informações não localizadas");
            }          

            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
    }
}
