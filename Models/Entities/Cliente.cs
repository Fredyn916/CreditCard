﻿using Models.Entities.Enumerable;

namespace Models.Entities;

class Cliente
{
    public int Id { get; set; }
    public String Nome { get; set; }
    public String CPF { get; set; }
    public int Idade { get; set; }
    public String Telefone { get; set; }
    public String Email { get; set; }
    public String Password { get; set; }
    public Genero Genero { get; set; }
}