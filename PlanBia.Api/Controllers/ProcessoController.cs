using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;
using System.Diagnostics;

namespace PlanBia.Api.Controllers;

[ApiController]
[Route("v1/api/[controller]/[action]")]
public class ProcessoController : Controller
{
    private readonly IProcessoService _service;

    public ProcessoController(IProcessoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var processo = await _service.Get();
        return Ok(processo);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var processo = await _service.Get(id);

        if (processo == null)
            return BadRequest("O Processo não foi localizado!!!!");

        return Ok(processo);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProcessoDtoFlat processoDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }

        var result = await _service.Create(processoDto);

        return Ok(result);
    }


    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id, ProcessoDtoFlat processoDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }


        var result = await _service.Update(id, processoDto);

        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);

        if (!result)
            return BadRequest("Processo já foi removido!");

        return Ok(result);
    }
}
