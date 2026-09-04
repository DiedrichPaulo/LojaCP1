namespace CP1.Api.Properties.Domain.Entities;

public class Pagamento
{
    public int IdPagamento { get; set; }

    public float VlPagamento { get; set; }

    public DateTime DtPagamento { get; set; }

    public string TpPagamento { get; set; } = string.Empty;

    public int IdPedido { get; set; }

    public int IdCliente { get; set; }

    public int IdEntrega { get; set; }

    public Pedido Pedido { get; set; } = null!;

    public Cliente Cliente { get; set; } = null!;

    public Entrega Entrega { get; set; } = null!;
}