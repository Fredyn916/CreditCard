namespace Models.Entities;

class Transacao
{
    public int Id { get; set; }
    public double Valor { get; set; }
    public DateTime Data { get; set; }
    public String Remetente { get; set; }
    public bool isInstallments { get; set; }
    public double? ValorParcela { get; set; }
    public int? QuantidadeParcelas { get; set; }
    public int? QuantidadeParcelasPagas { get; set; }
}