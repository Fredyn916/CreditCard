using Models.Entities;

namespace Services.Interfaces;

public interface IContaService
{
    Task<Conta> Post(Conta conta);
    Task<List<Conta>> Get();
    Task<Conta> GetById(int id);
    Task Put(Conta editConta);
    Task Delete(int id);
}