namespace CP1.Api.Properties.Domain.Entities;

public class Produto
{
    public int IdProduto { get; set; }

    public string NmProduto { get; set; } = string.Empty;

    public float VlPreco { get; set; }

    public string NmCategoria { get; set; } = string.Empty;

    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}