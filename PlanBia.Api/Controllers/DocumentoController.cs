using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;

namespace PlanBia.Api.Controllers;

[ApiController]
[Route("v1/api/[controller]/[action]")]
public class DocumentoController : Controller
{
    private readonly IDocumentoService _service;
    public DocumentoController(IDocumentoService service)
    {
        _service = service;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var documento = await _service.Get();
        return Ok(documento);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var documento = await _service.Get(id);
        if (documento == null)
        {
            return BadRequest("Documento nao encontrado.");
        }
        return Ok(documento);
    }

    [HttpPost]
    public async Task<IActionResult> Create(DocumentoDtoFlat documentoDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Dados incorretos.");
        }
        var result = await _service.Create(documentoDto);
        return Ok(result);
    }

    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id, DocumentoDtoFlat documentoDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Dados Incorretos.");
        }
        var result = _service.Update(id, documentoDto);
        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);
        if (!result)
            return BadRequest("Documento nao encontrado");
        return Ok(result);
    }
}
