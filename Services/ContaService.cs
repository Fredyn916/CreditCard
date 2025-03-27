using DAO.Interfaces;
using Models.Entities;
using Services.Interfaces;

namespace Services;

public class ContaService : IContaService
{
    private readonly IContaRepository _contaRepository;

    public ContaService(IContaRepository contaRepository)
    {
        _contaRepository = contaRepository;
    }

    public async Task<Conta> Post(Conta conta)
    {
        return await _contaRepository.Post(conta);
    }

    public async Task<List<Conta>> Get()
    {
        return await _contaRepository.Get();
    }

    public async Task<Conta> GetById(int id)
    {
        return await _contaRepository.GetById(id);
    }

    public async Task Put(Conta editConta)
    {
        await _contaRepository.Put(editConta);
    }

    public async Task Delete(int id)
    {
        await _contaRepository.Delete(id);
    }
}