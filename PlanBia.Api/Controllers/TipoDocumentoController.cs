using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;

namespace PlanBia.Api.Controllers;
[ApiController]
[Route("v1/api/[controller]/[action]")]
public class TipoDocumentoController : Controller
{
    private readonly ITipoDocumentoService _service;

    public TipoDocumentoController(ITipoDocumentoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var tipoDocumento = await _service.Get();
        return Ok(tipoDocumento);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var tipoDocumento = await _service.Get(id);

        if (tipoDocumento == null)
            return BadRequest("O Tipo Documento não foi localizado!!!!");

        return Ok(tipoDocumento);
    }

    [HttpPost]
    public async Task<IActionResult> Create(TipoDocumentoDtoFlat tipoDocumentoDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }

        var result = await _service.Create(tipoDocumentoDto);

        return Ok(result);
    }


    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id, TipoDocumentoDtoFlat tipoDocumentoDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }


        var result = await _service.Update(id, tipoDocumentoDto);

        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);

        if (!result)
            return BadRequest("Tipo documento nao encontrado.");

        return Ok(result);
    }
}
