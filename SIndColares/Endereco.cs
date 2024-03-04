namespace Models;

public class Endereco
{
    public int Id { get; set; } = 0;
    public int CEP { get; set; } = 0;
    public string UF { get; set; } = string.Empty;
    public string Municipio { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Rua { get; set;} = string.Empty;
    public int Numero { get; set; } = 0;
}
