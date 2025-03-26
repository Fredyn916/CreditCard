using DAO.Interfaces;
using Models.Entities;
using Services.Interfaces;

namespace Services;

public class TransacaoService : ITransacaoService
{
    private readonly ITransacaoRepository _transacaoRepository;

    public TransacaoService(ITransacaoRepository transacaoRepository)
    {
        _transacaoRepository = transacaoRepository;
    }

    public async Task Post(Transacao transacao)
    {
        await _transacaoRepository.Post(transacao);
    }

    public async Task<List<Transacao>> Get()
    {
        return await _transacaoRepository.Get();
    }

    public async Task<Transacao> GetById(int id)
    {
        return await _transacaoRepository.GetById(id);
    }

    public async Task Put(Transacao editTransacao)
    {
        await _transacaoRepository.Put(editTransacao);
    }

    public async Task Delete(int id)
    {
        await _transacaoRepository.Delete(id);
    }
}