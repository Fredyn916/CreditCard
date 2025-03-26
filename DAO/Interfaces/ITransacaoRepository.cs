using Models.Entities;

namespace DAO.Interfaces;

public interface ITransacaoRepository
{
    Task Post(Transacao transacao);
    Task<List<Transacao>> Get();
    Task<Transacao> GetById(int id);
    Task Put(Transacao editTransacao);
    Task Delete(int id);
}