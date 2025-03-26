using DAO.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using Models.Entities;
using System.Data.SQLite;

namespace DAO;

public class ClienteRepository : IClienteRepository
{
    private readonly string _connectionString;

    public ClienteRepository(IConfiguration connection)
    {
        _connectionString = connection.GetConnectionString("DefaultConnection");
    }

    public async Task<int> Post(Cliente cliente)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.InsertAsync<Cliente>(cliente);
        return cliente.Id;
    }

    public async Task<List<Cliente>> Get()
    {
        using var connection = new SQLiteConnection(_connectionString);

        var clientes = await connection.GetAllAsync<Cliente>();
        return clientes.ToList();
    }

    public async Task<Cliente> GetById(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        return await connection.GetAsync<Cliente>(id);
    }

    public async Task Put(Cliente editCliente)
    {
        using var connection = new SQLiteConnection(_connectionString);

        await connection.UpdateAsync<Cliente>(editCliente);
    }

    public async Task Delete(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);

        Cliente clienteToRemove = GetById(id).Result;

        await connection.DeleteAsync<Cliente>(clienteToRemove);
    }
}