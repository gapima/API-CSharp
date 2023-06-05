using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;

namespace PlanBia.Api.Controllers;

[ApiController]
[Route("v1/api/[controller]/[action]")]
public class CredoresController : Controller
{
    private readonly ICredoresService _service;

    public CredoresController(ICredoresService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var credores = await _service.Get();
        return Ok(credores);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var credores = await _service.Get(id);
        if (credores == null)
            return BadRequest("Credor nao encontrado.");
        return Ok(credores);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CredoresDtoFlat credoresDto)
    {
        if(ModelState.IsValid)
        {
            return BadRequest("Dados Incorretos.");
        }
        var result = await _service.Create(credoresDto);
        return Ok(result);
    }

    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id, CredoresDtoFlat credoresDto)
    {
        if (ModelState.IsValid)
        {
            return BadRequest("Dados Incorretos.");
        }
        var result = _service.Update(id, credoresDto);
        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);

        if (!result)
            return BadRequest("Credor já foi removido!");

        return Ok(result);
    }
}
