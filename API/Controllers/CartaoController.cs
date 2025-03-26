using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Models.Entities;
using Services.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class CartaoController : ControllerBase
{
    private readonly ICartaoService _cartaoService;
    private readonly IMapper _mapper;

    public CartaoController(ICartaoService cartaoService, IMapper mapper)
    {
        _cartaoService = cartaoService;
        _mapper = mapper;
    }

    [HttpPost("PostCartao")]
    public async Task<int> Post(CartaoDTO cartaoDTO)
    {
        try
        {
            Cartao cartao = _mapper.Map<Cartao>(cartaoDTO);

            return await _cartaoService.Post(cartao);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetCartao")]
    public async Task<List<Cartao>> Get()
    {
        try
        {
            return await _cartaoService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdCartao")]
    public async Task<Cartao> GetById(int id)
    {
        try
        {
            return await _cartaoService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutCartao")]
    public async Task<IActionResult> Put(Cartao cartao)
    {
        try
        {
            await _cartaoService.Put(cartao);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteCartao")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _cartaoService.Delete(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}