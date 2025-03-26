using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Models.Entities;
using System.Data.SQLite;

namespace DAO;

public class TransacaoRepository : ITransacaoRepository
{
    private readonly string _connectionString;

    public TransacaoRepository(IConfiguration connection)
    {
        _connectionString = connection.GetConnectionString("DefaultConnection");
    }

    public async Task Post(Transacao transacao)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.InsertAsync<Transacao>(transacao);
    }

    public async Task<List<Transacao>> Get()
    {
        using var connection = new SQLiteConnection(_connectionString);

        var transacoes = await connection.GetAllAsync<Transacao>();
        return transacoes.ToList();
    }

    public async Task<Transacao> GetById(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        return await connection.GetAsync<Transacao>(id);
    }

    public async Task Put(Transacao editTransacao)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.UpdateAsync<Transacao>(editTransacao);
    }

    public async Task Delete(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        Transacao transacaoToRemove = GetById(id).Result;

        await connection.DeleteAsync<Transacao>(transacaoToRemove);
    }
}