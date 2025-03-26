using Models.Entities.Enumerable;

namespace Models.DTO;

public class CartaoDTO
{
    public int ClienteId { get; set; }
    public String Titular { get; set; }
    public Step Step { get; set; }
}