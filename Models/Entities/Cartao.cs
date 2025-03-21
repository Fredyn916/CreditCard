using System.ComponentModel;

namespace Models.Entities;

class Cartao
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public String NumeroCartao { get; set; }
    public String Titular { get; set; }
    public DateOnly Validade { get; set; }
    public int CVV { get; set; }
    public double Limite { get; set; }
    public bool isActive { get; set; }
    public List<Fatura> Faturas { get; set; }
}