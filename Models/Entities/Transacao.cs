using Dapper.Contrib.Extensions;

namespace Models.Entities;

[Table("Transacoes")]
public class Transacao
{
    public int Id { get; set; }
    public double Valor { get; set; }
    public DateTime DataCompra { get; set; }
    public String Remetente { get; set; }
    public bool isInstallments { get; set; }
    public double? ValorParcela { get; set; }
    public int? QuantidadeParcelasReferente { get; set; }
    public int? QuantidadeParcelas { get; set; }
}