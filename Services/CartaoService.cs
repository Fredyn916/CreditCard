using DAO.Interfaces;
using Models.Entities;
using Services.Interfaces;

namespace Services;

public class CartaoService : ICartaoService
{
    private readonly ICartaoRepository _cartaoRepository;

    public CartaoService(ICartaoRepository cartaoRepository)
    {
        _cartaoRepository = cartaoRepository;
    }

    public async Task Post(Cartao cartao)
    {
        await _cartaoRepository.Post(cartao);
    }

    public async Task<List<Cartao>> Get()
    {
        return await _cartaoRepository.Get();
    }

    public async Task<Cartao> GetById(int id)
    {
        return await _cartaoRepository.GetById(id);
    }

    public async Task Put(Cartao editCartao)
    {
        await _cartaoRepository.Put(editCartao);
    }

    public async Task Delete(int id)
    {
        await _cartaoRepository.Delete(id);
    }
}