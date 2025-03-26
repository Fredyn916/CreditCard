using Models.Entities;

namespace DAO.Interfaces;

public interface ICartaoRepository
{
    Task<int> Post(Cartao cartao);
    Task<List<Cartao>> Get();
    Task<Cartao> GetById(int id);
    Task Put(Cartao editCartao);
    Task Delete(int id);
}