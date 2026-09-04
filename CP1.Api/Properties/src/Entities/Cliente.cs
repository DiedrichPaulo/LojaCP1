namespace CP1.Api.Properties.Domain.Entities;

public class Cliente
{
    public int IdCliente { get; set; }

    public string NmCliente { get; set; } = string.Empty;

    public int NrCpf { get; set; }

    public int NrTelefone { get; set; }

    public string NmEmail { get; set; } = string.Empty;

    public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();

    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}