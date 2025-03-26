using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Models.Entities;
using System.Data.SQLite;

namespace DAO;

public class CartaoRepository : ICartaoRepository
{
    private readonly string _connectionString;

    public CartaoRepository(IConfiguration connection)
    {
        _connectionString = connection.GetConnectionString("DefaultConnection");
    }

    public async Task Post(Cartao cartao)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.InsertAsync<Cartao>(cartao);
    }

    public async Task<List<Cartao>> Get()
    {
        using var connection = new SQLiteConnection(_connectionString);

        var cartoes = await connection.GetAllAsync<Cartao>();
        return cartoes.ToList();
    }

    public async Task<Cartao> GetById(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        return await connection.GetAsync<Cartao>(id);
    }

    public async Task Put(Cartao editCartao)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.UpdateAsync<Cartao>(editCartao);
    }

    public async Task Delete(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        Cartao cartaoToRemove = GetById(id).Result;

        await connection.DeleteAsync<Cartao>(cartaoToRemove);
    }
}