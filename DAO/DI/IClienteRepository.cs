using Models.Entities;

namespace DAO.DI;

public interface IClienteRepository
{
    Task Post(Cliente cliente);
    Task<List<Cliente>> Get();
    Task<Cliente> GetById(int id);
    Task Put(Cliente editCliente);
    Task Delete(int id);
}