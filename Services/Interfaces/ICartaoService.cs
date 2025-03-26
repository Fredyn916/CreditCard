using Models.Entities;

namespace Services.Interfaces;

public interface ICartaoService
{
    Task Post(Cartao cartao);
    Task<List<Cartao>> Get();
    Task<Cartao> GetById(int id);
    Task Put(Cartao editCartao);
    Task Delete(int id);
}