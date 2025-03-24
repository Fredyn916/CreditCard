using Models.Entities;

namespace DAO.DI;

public interface ICartaoRepository
{
    Task Post(Cartao cartao);
    Task<List<Cartao>> Get();
    Task<Cartao> GetById(int id);
    Task Put(Cartao editCartao);
    Task Delete(int id);
}