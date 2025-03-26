using DAO.Interfaces;
using Models.Entities;
using Services.Interfaces;

namespace Services;

public class FaturaService : IFaturaService
{
    private readonly IFaturaRepository _faturaRepository;

    public FaturaService(IFaturaRepository faturaRepository)
    {
        _faturaRepository = faturaRepository;
    }

    public async Task Post(Fatura fatura)
    {
        await _faturaRepository.Post(fatura);
    }

    public async Task<List<Fatura>> Get()
    {
        return await _faturaRepository.Get();
    }

    public async Task<Fatura> GetById(int id)
    {
        return await _faturaRepository.GetById(id);
    }

    public async Task Put(Fatura editFatura)
    {
        await _faturaRepository.Put(editFatura);
    }

    public async Task Delete(int id)
    {
        await _faturaRepository.Delete(id);
    }
}