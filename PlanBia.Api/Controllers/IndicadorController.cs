using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;

namespace PlanBia.Api.Controllers;
[ApiController]
[Route("v1/api/[controller]/[action]")]
public class IndicadorController : Controller
{
    private IIndicadorService _service;
    public IndicadorController(IIndicadorService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var indicador = await _service.Get();
        return Ok(indicador);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GatById(Guid id)
    {
        var indicador = await _service.Get(id);
        if (indicador == null)
            return BadRequest("Indicador nao enontrado.");
        return Ok(indicador);
    }

    [HttpPost]
    public async Task<IActionResult> Create(IndicadorDtoFlat indicadorDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Dados incorretos.");
        }
        var result = await _service.Create(indicadorDto);
        return Ok(result);
    }

    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id, IndicadorDtoFlat indicadorDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Indicador nao encontrado");
        }
        var result = await _service.Update(id, indicadorDto);
        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);

        if (!result)
            return BadRequest("Indicador nao encontrado!");

        return Ok(result);
    }
}
