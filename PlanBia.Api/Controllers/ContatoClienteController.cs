using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;

namespace PlanBia.Api.Controllers;

[ApiController]
[Route("v1/api/[controller]/[action]")]
public class ContatoClienteController : Controller
{
    private readonly IContatoClienteService _service;

    public ContatoClienteController(IContatoClienteService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var contatoCliente = await _service.Get();
        return Ok(contatoCliente);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var contatoCliente = await _service.Get(id);
        if (contatoCliente == null)
            return BadRequest("Contato Nao Localizado.");
        return Ok(contatoCliente);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ContatoClienteDtoFlat contatoClienteDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }

        var result = await _service.Create(contatoClienteDto);
        return Ok(result);
    }

    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id, ContatoClienteDtoFlat contatoClienteDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }
        var result = await _service.Update(id, contatoClienteDto);
        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);
        if (!result)
            return BadRequest("Contato do cliente já foi removido!");
        return Ok(result);

    }
}
