namespace Models.Entities;

class Fatura
{
    public int Id { get; set; }
    public double Valor { get; set; }
    public bool isClosed { get; set; }
    public DateOnly DataFechamento { get; set; }
    public List<Transacao> Transacoes { get; set; }
    public bool isPaid { get; set; }
    public int CartaoId { get; set; }
}