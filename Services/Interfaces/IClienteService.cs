using Models.Entities;

namespace Services.Interfaces;

public interface IClienteService
{
    Task<int> Post(Cliente cliente);
    Task<List<Cliente>> Get();
    Task<Cliente> GetById(int id);
    Task Put(Cliente editCliente);
    Task Delete(int id);
}