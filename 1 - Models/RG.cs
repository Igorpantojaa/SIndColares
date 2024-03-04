namespace Models;

public class RG
{
    public int Id { get; set; }
    public int AssociadoId { get; set; }
    public DateTime DataEmisao { get; set; }
    public string Numero { get; set; } = string.Empty;
    public string NomePai { get; set; } = string.Empty;
    public string NomeMae { get; set; } = string.Empty;
    public string OrgaoEmissor { get; set; } = string.Empty;
    public string Nacionalidade { get; set; } = string.Empty;
}