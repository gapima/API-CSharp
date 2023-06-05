using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;
using Siderum.Domain.Entities;

namespace PlanBia.Api.Controllers;

[ApiController]
[Route("v1/api/[controller]/[action]")]
public class RendaClienteController : Controller
{
    private readonly IRendaClienteService _service;

    public RendaClienteController(IRendaClienteService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var RendaCliente = await _service.Get();
        return Ok(RendaCliente);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var RendaCliente = await _service.Get(id);

        if (RendaCliente == null)
            return BadRequest("O Renda cliente não foi localizado!!!!");

        return Ok(RendaCliente);
    }

    [HttpPost]
    public async Task<IActionResult> Create(RendaClienteDtoFlat rendaClienteDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }

        var result = await _service.Create(rendaClienteDto);

        return Ok(result);
    }


    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id, RendaClienteDtoFlat rendaClienteDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }


        var result = await _service.Update(id, rendaClienteDto);

        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);

        if (!result)
            return BadRequest("Renda cliente nao encontrada!");

        return Ok(result);
    }
}
