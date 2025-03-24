using DAO.DI;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Models.Entities;
using System.Data.SQLite;

namespace DAO;

public class ContaRepository : IContaRepository
{
    private readonly string _connectionString;

    public ContaRepository(IConfiguration connection)
    {
        _connectionString = connection.GetConnectionString("DefaultConnection");
    }

    public async Task Post(Conta conta)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.InsertAsync<Conta>(conta);
    }

    public async Task<List<Conta>> Get()
    {
        using var connection = new SQLiteConnection(_connectionString);

        var contas = await connection.GetAllAsync<Conta>();
        return contas.ToList();
    }

    public async Task<Conta> GetById(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        return await connection.GetAsync<Conta>(id);
    }

    public async Task Put(Conta editConta)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.UpdateAsync<Conta>(editConta);
    }

    public async Task Delete(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        Conta contaToRemove = GetById(id).Result;

        await connection.DeleteAsync<Conta>(contaToRemove);
    }
}