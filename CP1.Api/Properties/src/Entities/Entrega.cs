namespace CP1.Api.Properties.Domain.Entities;

public class Entrega
{
    public int IdEntrega { get; set; }

    public DateTime DtSaida { get; set; }

    public DateTime DtChegada { get; set; }

    public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();

    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}