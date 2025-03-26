﻿using Models.Entities;

namespace DAO.Interfaces;

public interface IClienteRepository
{
    Task<int> Post(Cliente cliente);
    Task<List<Cliente>> Get();
    Task<Cliente> GetById(int id);
    Task Put(Cliente editCliente);
    Task Delete(int id);
}