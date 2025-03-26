using Models.Entities;

namespace Services.Interfaces;

public interface IFaturaService
{
    Task Post(Fatura fatura);
    Task<List<Fatura>> Get();
    Task<Fatura> GetById(int id);
    Task Put(Fatura editFatura);
    Task Delete(int id);
}