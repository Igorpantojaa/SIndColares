namespace Modelos;

public class Endereco
{
    public int id { get; set; }
    public int AssociadoId { get; set; }
    public string CEP { get; set; } = string.Empty;
    public string UF { get; set; } = string.Empty;
    public string Municipio { get; set; } = string.Empty;
    public string Localidade { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Rua { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
}
