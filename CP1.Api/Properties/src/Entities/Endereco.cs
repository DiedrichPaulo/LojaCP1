namespace CP1.Api.Properties.Domain.Entities;

public class Endereco
{
    public int IdEndereco { get; set; }

    public string NmLogradouro { get; set; } = string.Empty;

    public int NrEndereco { get; set; }

    public int NrComplemento { get; set; }

    public int NrCep { get; set; }

    public string NmBairro { get; set; } = string.Empty;

    public string NmCidade { get; set; } = string.Empty;

    public string NmEstado { get; set; } = string.Empty;

    public int IdEntrega { get; set; }

    public int IdCliente { get; set; }

    public Cliente Cliente { get; set; } = null!;

    public Entrega Entrega { get; set; } = null!;
}

