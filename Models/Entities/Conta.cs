namespace Models.Entities;

class Conta
{
    public int Id { get; set; }
    public String NumeroAgencia = "6633-9";
    public String NumeroConta { get; set; }
    public double Saldo { get; set; }
    public int CartaoId { get; set; }
    public int ClienteId { get; set; }
}