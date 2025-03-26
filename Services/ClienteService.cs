using DAO.Interfaces;
using Models.Entities;
using Services.Interfaces;

namespace Services;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task Post(Cliente cliente)
    {
        await _clienteRepository.Post(cliente);
    }

    public async Task<List<Cliente>> Get()
    {
        return await _clienteRepository.Get();
    }

    public async Task<Cliente> GetById(int id)
    {
        return await _clienteRepository.GetById(id);
    }

    public async Task Put(Cliente editCliente)
    {
        await _clienteRepository.Put(editCliente);
    }

    public async Task Delete(int id)
    {
        await _clienteRepository.Delete(id);
    }
}