using Dapper.Contrib.Extensions;
using Models.Entities.Enumerable;

namespace Models.Entities;

[Table("Cartoes")]
public class Cartao
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public String NumeroCartao { get; set; }
    public String Titular { get; set; }
    public DateOnly Validade { get; set; }
    public int CVV { get; set; }
    public double Limite { get; set; }
    public Step Step { get; set; }
    public bool isActive { get; set; }
    public virtual List<Fatura> Faturas { get; set; }
}