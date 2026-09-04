namespace CP1.Api.Properties.Domain.Entities;

public class Pedido
{
    public int IdPedido { get; set; }

    public DateTime DtPedido { get; set; }

    public string StPedido { get; set; } = string.Empty;

    public int IdCliente { get; set; }

    public int IdEntrega { get; set; }

    public Cliente Cliente { get; set; } = null!;

    public Entrega Entrega { get; set; } = null!;

    public Pagamento? Pagamento { get; set; }

    public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}