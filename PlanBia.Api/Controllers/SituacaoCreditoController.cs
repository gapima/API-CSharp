using Microsoft.AspNetCore.Mvc;
using PlanBia.Application.Dtos;
using PlanBia.Application.Interfaces;

namespace PlanBia.Api.Controllers;
[ApiController]
[Route("v1/api/[controller]/[action]")]
public class SituacaoCreditoController : Controller
{
    private readonly ISituacaoCreditoService _service;

    public SituacaoCreditoController(ISituacaoCreditoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var situacaoCredito = await _service.Get();
        return Ok(situacaoCredito);
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var situacaoCredito = await _service.Get(id);

        if (situacaoCredito == null)
            return BadRequest("Situacao credito não foi localizado!!!!");

        return Ok(situacaoCredito);
    }

    [HttpPost]
    public async Task<IActionResult> Create(SituacaoCreditoDtoFlat situacaoCreditoDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }

        var result = await _service.Create(situacaoCreditoDto);

        return Ok(result);
    }


    [HttpPut]
    [Route("Update/{id}")]
    public async Task<IActionResult> Update(Guid id, SituacaoCreditoDtoFlat situacaoCreditoDto)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest("Passa os dados direito ae!!!");
        }


        var result = await _service.Update(id, situacaoCreditoDto);

        return Ok(result);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _service.Delete(id);

        if (!result)
            return BadRequest("Situacao Credito nao encontrado!");

        return Ok(result);
    }
}
