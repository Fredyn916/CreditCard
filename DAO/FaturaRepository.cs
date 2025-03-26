using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Models.Entities;
using System.Data.SQLite;

namespace DAO;

public class FaturaRepository : IFaturaRepository
{
    private readonly string _connectionString;

    public FaturaRepository(IConfiguration connection)
    {
        _connectionString = connection.GetConnectionString("DefaultConnection");
    }

    public async Task Post(Fatura fatura)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.InsertAsync<Fatura>(fatura);
    }

    public async Task<List<Fatura>> Get()
    {
        using var connection = new SQLiteConnection(_connectionString);

        var faturas = await connection.GetAllAsync<Fatura>();
        return faturas.ToList();
    }

    public async Task<Fatura> GetById(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        return await connection.GetAsync<Fatura>(id);
    }

    public async Task Put(Fatura editFatura)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.UpdateAsync<Fatura>(editFatura);
    }

    public async Task Delete(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        Fatura faturaToRemove = GetById(id).Result;

        await connection.DeleteAsync<Fatura>(faturaToRemove);
    }
}