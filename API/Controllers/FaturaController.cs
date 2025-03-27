using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Services.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FaturaController : ControllerBase
{
    private readonly IFaturaService _faturaService;
    private readonly IMapper _mapper;

    public FaturaController(IFaturaService faturaService, IMapper mapper)
    {
        _faturaService = faturaService;
        _mapper = mapper;
    }

    [HttpPost("PostFatura")]
    public async Task<IActionResult> Post(Fatura fatura)
    {
        try
        {
            await _faturaService.Post(fatura);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetFatura")]
    public async Task<List<Fatura>> Get()
    {
        try
        {
            return await _faturaService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdFatura")]
    public async Task<Fatura> GetById(int id)
    {
        try
        {
            return await _faturaService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutFatura")]
    public async Task<IActionResult> Put(Fatura fatura)
    {
        try
        {
            await _faturaService.Put(fatura);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteFatura")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _faturaService.Delete(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}