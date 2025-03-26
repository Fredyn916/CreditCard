using Models.Entities.Enumerable;

namespace Models.DTO;

public class ClienteDTO
{
    public String Nome { get; set; }
    public String CPF { get; set; }
    public int Idade { get; set; }
    public String Telefone { get; set; }
    public String Email { get; set; }
    public String Password { get; set; }
    public Genero Genero { get; set; }
    public double RendaMensal { get; set; }
}