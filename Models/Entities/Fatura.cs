using Dapper.Contrib.Extensions;

namespace Models.Entities;

[Table("Faturas")]
public class Fatura
{
    public int Id { get; set; }
    public String Mes { get; set; }
    public double Valor { get; set; }
    public bool isClosed { get; set; }
    public DateOnly DataFechamento { get; set; }
    public bool isPaid { get; set; }
    public int CartaoId { get; set; }
    public virtual List<Transacao> Transacoes { get; set; }
}