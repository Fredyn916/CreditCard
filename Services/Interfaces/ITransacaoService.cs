using Models.Entities;

namespace Services.Interfaces;

public interface ITransacaoService
{
    Task Post(Transacao transacao);
    Task<List<Transacao>> Get();
    Task<Transacao> GetById(int id);
    Task Put(Transacao editTransacao);
    Task Delete(int id);
}