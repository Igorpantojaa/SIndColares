namespace Modelos;

public class Endereco
{
    public int id { get; set; }
    public int AssociadoId { get; set; }
    public int CEP { get; set; } = 0;
    public string UF { get; set; } = string.Empty;
    public string Municipio { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Rua { get; set; } = string.Empty;
    public int Numero { get; set; } = 0;
}
