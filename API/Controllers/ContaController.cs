using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Services.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContaController : ControllerBase
{
    private readonly IContaService _contaService;
    private readonly IMapper _mapper;

    public ContaController(IContaService contaService, IMapper mapper)
    {
        _contaService = contaService;
        _mapper = mapper;
    }

    [HttpPost("PostConta")]
    public async Task<Conta> Post(int cartaoId, int clienteId)
    {
        try
        {
            Conta conta = new Conta();
            conta.ClienteId = clienteId;
            conta.CartaoId = cartaoId;

            return await _contaService.Post(conta);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetConta")]
    public async Task<List<Conta>> Get()
    {
        try
        {
            return await _contaService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdConta")]
    public async Task<Conta> GetById(int id)
    {
        try
        {
            return await _contaService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutConta")]
    public async Task<IActionResult> Put(Conta conta)
    {
        try
        {
            await _contaService.Put(conta);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteConta")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _contaService.Delete(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}