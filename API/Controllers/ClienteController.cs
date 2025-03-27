using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Models.Entities;
using Services.Interfaces;


namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;
    private readonly IMapper _mapper;

    public ClienteController(IClienteService clienteService, IMapper mapper)
    {
        _clienteService = clienteService;
        _mapper = mapper;
    }

    [HttpPost("PostCliente")]
    public async Task<Cliente> Post(ClienteDTO clienteDTO)
    {
        try
        {
            Cliente cliente = _mapper.Map<Cliente>(clienteDTO);

            return await _clienteService.Post(cliente);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetCliente")]
    public async Task<List<Cliente>> Get()
    {
        try
        {
            return await _clienteService.Get();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpGet("GetByIdCliente")]
    public async Task<Cliente> GetById(int id)
    {
        try
        {
            return await _clienteService.GetById(id);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    [HttpPut("PutCliente")]
    public async Task<IActionResult> Put(Cliente cliente)
    {
        try
        {
            await _clienteService.Put(cliente);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteCliente")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _clienteService.Delete(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}