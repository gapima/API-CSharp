using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using System.Runtime.CompilerServices;

namespace PlanBia.Api.Controllers;
[ApiController]
[Route("v1/api/[controller]/[action]")]
public class GrupoController : Controller
{
    private readonly IGrupoService _service;
    public GrupoController(IGrupoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var grupo = await _service.Get();
        return Ok(grupo);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var grupo = await _service.Get(id);
        if (grupo == null)
            return BadRequest("Grupo nao encontrado.");
        return Ok(grupo);
    }

    [HttpPost]
    public async Task<IActionResult> Create(GrupoDtoFlat grupoDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Dados incorretos");
        }
        var result = await _service.Create(grupoDto);
        return Ok(result);
    }

    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id,  GrupoDtoFlat grupoDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Dados incorretos");
        }
        var result = await _service.Update(id, grupoDto);
        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);
        if (!result)
            return BadRequest("Grupo nao foi encontrado.");
        return Ok(result);
    }
}
