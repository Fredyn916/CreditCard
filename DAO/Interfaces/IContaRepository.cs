using Models.Entities;

namespace DAO.Interfaces;

public interface IContaRepository
{
    Task Post(Conta conta);
    Task<List<Conta>> Get();
    Task<Conta> GetById(int id);
    Task Put(Conta editConta);
    Task Delete(int id);
}