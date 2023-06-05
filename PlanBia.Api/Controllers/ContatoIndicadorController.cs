using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;

namespace PlanBia.api.Controllers;

[ApiController]
[Route("v1/api/[controller]/[action]")]
public class ContatoIndicadorController : Controller
{
    private readonly IContatoIndicadorService _service;

    public ContatoIndicadorController(IContatoIndicadorService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var contatoIndicador = await _service.Get();
        return View(contatoIndicador);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var contatoIndicador = await _service.Get(id);
        if (contatoIndicador == null)
            return BadRequest("Contato Indicador nao existe.");
        return Ok(contatoIndicador);
    }

    [HttpPost]
   public async Task<IActionResult> Create(ContatoIndicadorDtoFlat contatoIndicadorDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Dados incorretos");
        }
        var result = await _service.Create(contatoIndicadorDto);
        return Ok(result);
    }

    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id, ContatoIndicadorDtoFlat contatoIndicadorDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Dados Incorretos");
        }
        var result = await _service.Update(id, contatoIndicadorDto);
        return Ok(result);
    }


    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);

        if (!result)
            return BadRequest("Contato Indicador já foi removido!");

        return Ok(result);
    }
}