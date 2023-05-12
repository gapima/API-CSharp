using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;

namespace PlanBia.Api.Controllers;

[ApiController]
[Route("v1/api/[controller]")]
public class ClientesController : Controller
{
    private readonly IClienteService _service;

    public ClientesController(IClienteService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var clientes = await _service.Get();
        return Ok(clientes);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var cliente = await _service.Get(id);

        if (cliente == null)
            return BadRequest("O Cliente não foi localizado!!!!");

        return Ok(cliente);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ClienteDtoFlat clienteDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }

        var result = await _service.Create(clienteDto);

        return Ok(result);
    }


    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id, ClienteDtoFlat clienteDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }


        var result = await _service.Update(id, clienteDto);

        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);

        if (!result)
            return BadRequest("Cliente já foi removido!");

        return Ok(result);
    }
}

