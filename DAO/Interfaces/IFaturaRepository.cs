using Models.Entities;

namespace DAO.Interfaces;

public interface IFaturaRepository
{
    Task Post(Fatura fatura);
    Task<List<Fatura>> Get();
    Task<Fatura> GetById(int id);
    Task Put(Fatura editFatura);
    Task Delete(int id);
}