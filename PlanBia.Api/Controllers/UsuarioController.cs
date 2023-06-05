using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;

namespace PlanBia.Api.Controllers;
[ApiController]
[Route("v1/api/[controller]/[action]")]
public class UsuarioController : Controller
{
    private readonly IUsuarioService _service;

    public UsuarioController(IUsuarioService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var usuario = await _service.Get();
        return Ok(usuario);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var usuario = await _service.Get(id);

        if (usuario == null)
            return BadRequest("O usuario não foi localizado!!!!");

        return Ok(usuario);
    }

    [HttpPost]
    public async Task<IActionResult> Create(UsuarioDtoFlat usuarioDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }

        var result = await _service.Create(usuarioDto);

        return Ok(result);
    }


    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id, UsuarioDtoFlat usuarioDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }


        var result = await _service.Update(id, usuarioDto);

        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);

        if (!result)
            return BadRequest("Usuario nao encontrado!");

        return Ok(result);
    }
}
